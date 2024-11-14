using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium210 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium210";
        public override double halfLife { get; } = 4.0d;
        public override double atomicWeight { get; } = 210.00048d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8171047.4), new Radon206() } },

        };
    }
}
    
    