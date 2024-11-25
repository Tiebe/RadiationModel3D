using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper68 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper68";
        public override double halfLife { get; } = 30.9d;
        public override double atomicWeight { get; } = 67.92961d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc68() }, { 1.0d, new BetaParticle(-1, 2220100.0) }, { 0.020952000000000002d, new GammaParticle(577800.0, 0.00215) }, { 0.010476000000000001d, new GammaParticle(736900.0, 0.00168) }, { 0.006984000000000001d, new GammaParticle(806900.0, 0.00154) }, { 0.6111d, new GammaParticle(1077700.0, 0.00115) }, { 0.144918d, new GammaParticle(1261800.0, 0.00098) }, { 0.0034920000000000003d, new GammaParticle(1292900.0, 0.00096) }, { 0.0026190000000000002d, new GammaParticle(1432800.0, 0.00087) }, { 0.00873d, new GammaParticle(1529700.0, 0.00081) }, { 0.015714d, new GammaParticle(1675700.0, 0.00074) }, { 0.01746d, new GammaParticle(1743700.0, 0.00071) }, { 0.020079d, new GammaParticle(1883800.0, 0.00066) }, { 0.015714d, new GammaParticle(2110100.0, 0.00059) }, { 0.014841d, new GammaParticle(2339500.0, 0.00053) }, { 2.87576327798712e-06d, new GammaParticle(1035.0, 1.19791) }, { 2.6983249296059133e-05d, new GammaParticle(8616.0, 0.1439) }, { 5.2476175215984303e-05d, new GammaParticle(8639.0, 0.14352) }, { 1.1259400453356556e-05d, new GammaParticle(9610.0, 0.12902) }, { 1.1259400453356556e-05d, new GammaParticle(9610.0, 0.12902) } } },

        };
    }
}
    