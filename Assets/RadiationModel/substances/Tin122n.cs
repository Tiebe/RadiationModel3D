using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin122n : RadioactiveSubstance
    {
        public override string name { get; } = "Tin122n";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 121.90641d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin122() } } },

        };
    }
}
    