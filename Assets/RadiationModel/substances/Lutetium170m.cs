using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium170m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium170m";
        public override double halfLife { get; } = 0.67d;
        public override double atomicWeight { get; } = 169.93858d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01333), new Lutetium170() } },

        };
    }
}
    
    