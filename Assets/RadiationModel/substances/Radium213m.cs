using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium213m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium213m";
        public override double halfLife { get; } = 0.0022d;
        public override double atomicWeight { get; } = 213.00227d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99d, new List<RadioactiveSubstance> { new GammaParticle(0.0007), new Radium213() } },
            { 0.006d, new List<RadioactiveSubstance> { new AlphaParticle(9650047.4), new Radon209() } },

        };
    }
}
    
    