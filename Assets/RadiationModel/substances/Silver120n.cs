using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver120n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver120n";
        public override double halfLife { get; } = 0.32d;
        public override double atomicWeight { get; } = 119.919d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.63d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium120() }, { 1.0d, new BetaParticle(-1, 4254000.0) }, { 0.57d, new GammaParticle(505900.0, 0.00245) }, { 0.57d, new GammaParticle(697800.0, 0.00178) }, { 0.17d, new GammaParticle(830000.0, 0.00149) }, { 0.4d, new GammaParticle(925800.0, 0.00134) } } },
            { 0.37d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver120() }, { 0.231d, new GammaParticle(203000.0, 0.00611) }, { 0.0075002367d, new GammaParticle(3218.0, 0.38528) }, { 0.024171619476149906d, new GammaParticle(21990.0, 0.05638) }, { 0.04556384444137587d, new GammaParticle(22163.0, 0.05594) }, { 0.012622475368376686d, new GammaParticle(25030.0, 0.04953) }, { 0.01481878608247423d, new GammaParticle(25211.0, 0.04918) }, { 0.0021963107140975436d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    