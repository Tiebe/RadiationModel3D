using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic79 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic79";
        public override double halfLife { get; } = 540.6d;
        public override double atomicWeight { get; } = 78.92095d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium79() }, { 1.0d, new BetaParticle(-1, 1140735.0) }, { 0.01875d, new GammaParticle(364500.0, 0.0034) }, { 0.0009750000000000001d, new GammaParticle(402300.0, 0.00308) }, { 0.015d, new GammaParticle(432000.0, 0.00287) }, { 0.002625d, new GammaParticle(446800.0, 0.00277) }, { 0.0036d, new GammaParticle(476000.0, 0.0026) }, { 0.00135d, new GammaParticle(552000.0, 0.00225) }, { 0.003d, new GammaParticle(715100.0, 0.00173) }, { 0.00114d, new GammaParticle(723600.0, 0.00171) }, { 0.0141d, new GammaParticle(878500.0, 0.00141) }, { 0.00132d, new GammaParticle(993400.0, 0.00125) } } },

        };
    }
}
    