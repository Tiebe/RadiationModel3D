using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium214n : RadioactiveSubstance
    {
        public override string name { get; } = "Radium214n";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 214.0021d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9991d, new List<RadioactiveSubstance> { new GammaParticle(0.00066), new Radium214() } },
            { 0.0009d, new List<RadioactiveSubstance> { new AlphaParticle(10158047.4), new Radon210() } },

        };
    }
}
    
    