using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon122 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon122";
        public override double halfLife { get; } = 72360.0d;
        public override double atomicWeight { get; } = 121.90837d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Iodine122() } },

        };
    }
}
    
    