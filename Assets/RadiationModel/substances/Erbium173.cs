using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium173";
        public override double halfLife { get; } = 84.0d;
        public override double atomicWeight { get; } = 172.9424d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium173() }, { 1.0d, new BetaParticle(-1, 1303000.0) }, { 0.001152d, new GammaParticle(2460.0, 0.504) }, { 0.048d, new GammaParticle(94200.0, 0.01316) }, { 0.18719999999999998d, new GammaParticle(116140.0, 0.01068) }, { 0.02544d, new GammaParticle(118600.0, 0.01045) }, { 0.2064d, new GammaParticle(122400.0, 0.01013) }, { 0.4656d, new GammaParticle(192800.0, 0.00643) }, { 0.48d, new GammaParticle(199200.0, 0.00622) }, { 0.096d, new GammaParticle(800800.0, 0.00155) }, { 0.5376d, new GammaParticle(895200.0, 0.00138) }, { 0.17626121097119998d, new GammaParticle(8215.0, 0.15092) }, { 0.17017722642378305d, new GammaParticle(49773.0, 0.02491) }, { 0.3004541426973571d, new GammaParticle(50742.0, 0.02443) }, { 0.09823496038004752d, new GammaParticle(57612.0, 0.02152) }, { 0.12377605007885988d, new GammaParticle(58257.0, 0.02128) }, { 0.025541089698812355d, new GammaParticle(59034.0, 0.021) } } },

        };
    }
}
    