using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium197 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium197";
        public override double halfLife { get; } = 53.6d;
        public override double atomicWeight { get; } = 196.98562d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.44d, new List<RadioactiveSubstance> { new AlphaParticle(7431047.4), new Lead193() } },

        };
    }
}
    
    