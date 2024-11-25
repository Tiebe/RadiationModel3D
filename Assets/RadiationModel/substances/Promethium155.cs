using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium155";
        public override double halfLife { get; } = 41.5d;
        public override double atomicWeight { get; } = 154.92814d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium155() }, { 1.0d, new BetaParticle(-1, 1625599.99999) }, { 0.009399999999999999d, new GammaParticle(53100.0, 0.02335) }, { 0.022000000000000002d, new GammaParticle(409800.0, 0.00303) }, { 0.053d, new GammaParticle(725400.0, 0.00171) }, { 0.015d, new GammaParticle(762000.0, 0.00163) }, { 0.078d, new GammaParticle(778600.0, 0.00159) }, { 0.01389494135282d, new GammaParticle(6354.0, 0.19513) }, { 0.021984272114365256d, new GammaParticle(39522.0, 0.03137) }, { 0.03979053776355703d, new GammaParticle(40117.0, 0.03091) }, { 0.012438441448392462d, new GammaParticle(45523.0, 0.02724) }, { 0.015647559342077715d, new GammaParticle(45998.0, 0.02695) }, { 0.0032091178936852548d, new GammaParticle(46575.0, 0.02662) } } },

        };
    }
}
    