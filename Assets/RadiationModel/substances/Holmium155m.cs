using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium155m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium155m";
        public override double halfLife { get; } = 0.00088d;
        public override double atomicWeight { get; } = 154.92926d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium155() } } },

        };
    }
}
    