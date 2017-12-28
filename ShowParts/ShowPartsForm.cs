using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using Tekla.Structures.Model.UI;

namespace ShowParts
{
	public partial class ShowParts : Form
	{
		private readonly Model _model = new Model();

		public ShowParts()
		{
			InitializeComponent();
		}

		private void ShowParts_Load(object sender, EventArgs e)
		{
			var mainParts = GetMainParts();

			var names = mainParts.Select(p => p.Name).Distinct().ToList();

			listBoxMainPartNames.DataSource = names;

			var showSettings = new List<Operation.UnselectedModeEnum>
			{
				Operation.UnselectedModeEnum.Hidden,
				Operation.UnselectedModeEnum.AsSticks,
				Operation.UnselectedModeEnum.Transparent
			};

			comboBox1ShowSettings.DataSource = showSettings;
		}

		private List<Part> GetMainParts()
		{
			ModelObjectEnumerator.AutoFetch = true;

			var beams = _model.GetModelObjectSelector()
				.GetAllObjectsWithType(ModelObject.ModelObjectEnum.BEAM)
				.ToAList<Beam>();

			var bentPlates = _model.GetModelObjectSelector()
				.GetAllObjectsWithType(ModelObject.ModelObjectEnum.BENT_PLATE)
				.ToAList<BentPlate>();

			var contourPlates = _model.GetModelObjectSelector()
				.GetAllObjectsWithType(ModelObject.ModelObjectEnum.CONTOURPLATE)
				.ToAList<ContourPlate>();

			var polybeams = _model.GetModelObjectSelector()
				.GetAllObjectsWithType(ModelObject.ModelObjectEnum.POLYBEAM)
				.ToAList<PolyBeam>();

			var parts = new List<Part>();

			parts.AddRange(beams);
			parts.AddRange(bentPlates);
			parts.AddRange(contourPlates);
			parts.AddRange(polybeams);

			var mainParts = parts.AsParallel().Where(p =>
			{
				int isMainPart = 0;
				p.GetReportProperty("MAIN_PART", ref isMainPart);
				return isMainPart > 0;
			}).ToList();

			return mainParts;
		}

		private void buttonSelectPartsInModel_Click(object sender, EventArgs e)
		{
			var selectedItems = listBoxMainPartNames.SelectedItems;

			var names = new List<string>();
			foreach (var item in selectedItems)
			{
				names.Add(item.ToString());
			}

			var modelObjects = GetMainParts().Where(p => names.Contains(p.Name)).OfType<ModelObject>().ToList();

			if (checkBoxShowSecondaries.Checked)
			{
				var secondaries = modelObjects
					.Where(p => p is Part)
					.SelectMany(p => ((Part)p).GetAssembly().GetSecondaries().OfType<ModelObject>())
					.ToList();

				modelObjects.AddRange(secondaries);
			}

			if (checkBoxBolts.Checked)
			{
				var bolts = modelObjects
					.Where(p => p is Part)
					.SelectMany(p => ((Part)p).GetBolts().ToAList<ModelObject>())
					.ToList();

				modelObjects.AddRange(bolts);
			}

			if (checkBoxCutsFittings.Checked)
			{
				var booleans = modelObjects
					.Where(p => p is Part)
					.SelectMany(p => ((Part)p).GetBooleans().ToAList<ModelObject>())
					.ToList();

				modelObjects.AddRange(booleans);
			}

			var objects = new ArrayList(modelObjects);
			new Tekla.Structures.Model.UI.ModelObjectSelector().Select(objects);

			var views = ViewHandler.GetVisibleViews().ToAList<Tekla.Structures.Model.UI.View>();
			views.ForEach(v => ViewHandler.RedrawView(v));

			Operation.ShowOnlySelected((Operation.UnselectedModeEnum)comboBox1ShowSettings.SelectedItem);
		}
	}
}
