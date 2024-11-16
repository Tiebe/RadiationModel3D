using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium217 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium217";
        public override double halfLife { get; } = 1.53d;
        public override double atomicWeight { get; } = 217.00632d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.975d, new List<RadioactiveSubstance> { new AlphaParticle(7682047.4), new Lead213() } },
            { 0.025d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1488000.0), new Astatine217() } },

        };
    }
}
    
    