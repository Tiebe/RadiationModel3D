
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon198 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon198";
        public override double halfLife { get; } = 0.0644d;
        public override double atomicWeight { get; } = 197.99868d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.93d, new List<RadioactiveSubstance> { new AlphaParticle(), new Polonium194() } },

        };
    }
}
    
    