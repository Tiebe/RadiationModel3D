using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium144m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium144m";
        public override double halfLife { get; } = 432.0d;
        public override double atomicWeight { get; } = 143.91337d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9993000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium144() }, { 0.0008119999999999999d, new GammaParticle(59030.0, 0.021) }, { 0.10459138274640001d, new GammaParticle(5637.0, 0.21995) }, { 0.08656884903129418d, new GammaParticle(35551.0, 0.03488) }, { 0.1580877447613115d, new GammaParticle(36027.0, 0.03441) }, { 0.0480937205472885d, new GammaParticle(40857.0, 0.03035) }, { 0.06040571300739435d, new GammaParticle(41266.0, 0.03005) }, { 0.012311992460105857d, new GammaParticle(41766.0, 0.02969) } } },
            { 0.0007000000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium144() }, { 1.0d, new BetaParticle(-1, 1528200.0) }, { 0.00017d, new GammaParticle(617800.0, 0.00201) }, { 0.00033d, new GammaParticle(1631360.0, 0.00076) }, { 0.00010999999999999999d, new GammaParticle(1885300.0, 0.00066) } } },

        };
    }
}
    