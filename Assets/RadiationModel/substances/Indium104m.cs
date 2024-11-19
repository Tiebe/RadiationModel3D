using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium104m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium104m";
        public override double halfLife { get; } = 15.7d;
        public override double atomicWeight { get; } = 103.91831d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new List<RadioactiveSubstance> { new GammaParticle((93000.0, 0.01333)), new Indium104() } },
            { 0.2d, new List<RadioactiveSubstance> { new BetaParticle(1, 7878400.0), new Cadmium104() } },

        };
    }
}
    
    