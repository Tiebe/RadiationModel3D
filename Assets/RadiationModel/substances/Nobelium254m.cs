using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium254m : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium254m";
        public override double halfLife { get; } = 0.2649d;
        public override double atomicWeight { get; } = 254.09235d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00096, 1296000.0), new Nobelium254() } },
            { 0.0002d, new List<RadioactiveSubstance> {  } },
            { 0.0001d, new List<RadioactiveSubstance> { new AlphaParticle(10542047.4), new Fermium250() } },

        };
    }
}
    
    