
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine201m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine201m";
        public override double halfLife { get; } = 0.045d;
        public override double atomicWeight { get; } = 200.98891d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Astatine201() } },

        };
    }
}
    
    