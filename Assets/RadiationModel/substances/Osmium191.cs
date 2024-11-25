using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium191 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium191";
        public override double halfLife { get; } = 1295136.0d;
        public override double atomicWeight { get; } = 190.96093d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium191() }, { 1.0d, new BetaParticle(-1, 156800.00001) }, { 5.8849999999999994e-05d, new GammaParticle(41846.0, 0.02963) }, { 2.5e-05d, new GammaParticle(47050.0, 0.02635) }, { 0.00031d, new GammaParticle(82427.0, 0.01504) }, { 0.265d, new GammaParticle(129431.0, 0.00958) }, { 0.4185705270703d, new GammaParticle(10728.0, 0.11557) }, { 0.15829375596473938d, new GammaParticle(63287.0, 0.01959) }, { 0.2716556649472102d, new GammaParticle(64896.0, 0.01911) }, { 0.0911506176835934d, new GammaParticle(73637.0, 0.01684) }, { 0.11694624248805031d, new GammaParticle(74510.0, 0.01664) }, { 0.02579562480445693d, new GammaParticle(75576.0, 0.01641) } } },

        };
    }
}
    