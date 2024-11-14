using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium255";
        public override double halfLife { get; } = 1620.0d;
        public override double atomicWeight { get; } = 255.09108d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new List<RadioactiveSubstance> { new BetaParticle(1, 1042000.0), new Fermium255() } },
            { 0.07d, new List<RadioactiveSubstance> { new AlphaParticle(8925047.4), new Einsteinium251() } },

        };
    }
}
    
    