
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium172p : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium172p";
        public override double halfLife { get; } = 0.00044d;
        public override double atomicWeight { get; } = 171.93921d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Lutetium172() } },

        };
    }
}
    
    