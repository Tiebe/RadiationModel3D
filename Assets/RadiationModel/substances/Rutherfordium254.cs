using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium254";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 254.10005d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },
            { 0.015d, new List<RadioactiveSubstance> { new AlphaParticle(10225047.4), new Nobelium250() } },

        };
    }
}
    
    