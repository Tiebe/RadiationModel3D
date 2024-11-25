using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine218 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine218";
        public override double halfLife { get; } = 1.28d;
        public override double atomicWeight { get; } = 218.0087d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth214() }, { 1.0d, new AlphaParticle(7898002.09) } } },
            { 0.0005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon218() }, { 1.0d, new BetaParticle(-1, 1441300.0) } } },

        };
    }
}
    