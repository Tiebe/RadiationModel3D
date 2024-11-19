using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium234";
        public override double halfLife { get; } = 7747231716000.0d;
        public override double atomicWeight { get; } = 234.04095d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(5879502.09), new Thorium230() } },
            { 1.64e-11d, new List<RadioactiveSubstance> {  } },
            { 1.4e-13d, new List<RadioactiveSubstance> { new Magnesium28(), new Mercury206() } },
            { 9e-14d, new List<RadioactiveSubstance> { new Neon24(), new Neon26(), new Hafnium184() } },

        };
    }
}
    
    