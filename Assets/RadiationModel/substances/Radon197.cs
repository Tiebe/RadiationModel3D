using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon197 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon197";
        public override double halfLife { get; } = 0.054d;
        public override double atomicWeight { get; } = 197.00162d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8430047.4), new Polonium193() } },

        };
    }
}
    
    