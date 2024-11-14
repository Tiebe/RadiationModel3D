using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium140";
        public override double halfLife { get; } = 291168.0d;
        public override double atomicWeight { get; } = 139.90955d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Praseodymium140() } },

        };
    }
}
    
    