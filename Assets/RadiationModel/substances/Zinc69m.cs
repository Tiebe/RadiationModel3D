using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc69m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc69m";
        public override double halfLife { get; } = 49521.6d;
        public override double atomicWeight { get; } = 68.92702d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99967d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc69() }, { 0.9484999999999999d, new GammaParticle(438634.0, 0.00283) }, { 0.0007044156261072001d, new GammaParticle(1035.0, 1.19791) }, { 0.006531729526249808d, new GammaParticle(8616.0, 0.1439) }, { 0.012702702306981345d, new GammaParticle(8639.0, 0.14352) }, { 0.002725518990768854d, new GammaParticle(9610.0, 0.12902) }, { 0.002725518990768854d, new GammaParticle(9610.0, 0.12902) } } },
            { 0.00033d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium69() }, { 1.0d, new BetaParticle(-1, 674250.0) }, { 0.00033d, new GammaParticle(573900.0, 0.00216) }, { 4.633721928e-09d, new GammaParticle(1127.0, 1.10013) }, { 4.13865002549852e-08d, new GammaParticle(9225.0, 0.1344) }, { 8.042460212783754e-08d, new GammaParticle(9252.0, 0.13401) }, { 1.7642025464390923e-08d, new GammaParticle(10306.0, 0.1203) }, { 1.774787761717727e-08d, new GammaParticle(10313.0, 0.12022) }, { 1.0585215278634554e-10d, new GammaParticle(10365.0, 0.11962) } } },

        };
    }
}
    