using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium152";
        public override double halfLife { get; } = 3.03d;
        public override double atomicWeight { get; } = 151.95033d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium152() }, { 1.0d, new BetaParticle(1, 7115000.0) }, { 0.11271d, new GammaParticle(141610.0, 0.00876) }, { 0.071094d, new GammaParticle(316750.0, 0.00391) }, { 0.867d, new GammaParticle(482320.0, 0.00257) }, { 0.005202d, new GammaParticle(827000.0, 0.0015) }, { 0.007803d, new GammaParticle(949130.0, 0.00131) }, { 1.3319999999999999d, new GammaParticle(511000.0, 0.00243) }, { 0.068253375719374d, new GammaParticle(8215.0, 0.15092) }, { 0.08233690389624393d, new GammaParticle(49773.0, 0.02491) }, { 0.14536882750043068d, new GammaParticle(50742.0, 0.02443) }, { 0.047529053458194775d, new GammaParticle(57612.0, 0.02152) }, { 0.05988660735732542d, new GammaParticle(58257.0, 0.02128) }, { 0.01235755389913064d, new GammaParticle(59034.0, 0.021) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    