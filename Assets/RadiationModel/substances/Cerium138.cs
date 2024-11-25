using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium138";
        public override double halfLife { get; } = 1.388504742882048e+24d;
        public override double atomicWeight { get; } = 137.90599d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium138() } } },

        };
    }
}
    