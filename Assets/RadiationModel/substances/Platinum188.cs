using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum188 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum188";
        public override double halfLife { get; } = 877824.0d;
        public override double atomicWeight { get; } = 187.9594d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9999997399999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium188() }, { 1.0d, new BetaParticle(1, 1658150.00001) }, { 0.0052d, new GammaParticle(41980.0, 0.02953) }, { 0.0075d, new GammaParticle(54850.0, 0.0226) }, { 0.00023d, new GammaParticle(92900.0, 0.01335) }, { 0.0017000000000000001d, new GammaParticle(96700.0, 0.01282) }, { 0.0034000000000000002d, new GammaParticle(98370.0, 0.0126) }, { 0.0025d, new GammaParticle(132860.0, 0.00933) }, { 0.023d, new GammaParticle(140350.0, 0.00883) }, { 0.191d, new GammaParticle(187590.0, 0.00661) }, { 0.184d, new GammaParticle(195050.0, 0.00636) }, { 0.0003d, new GammaParticle(197800.0, 0.00627) }, { 0.0031d, new GammaParticle(280300.0, 0.00442) }, { 0.001d, new GammaParticle(283150.0, 0.00438) }, { 0.0011d, new GammaParticle(290640.0, 0.00427) }, { 0.07400000000000001d, new GammaParticle(381430.0, 0.00325) }, { 0.043d, new GammaParticle(423340.0, 0.00293) }, { 0.018000000000000002d, new GammaParticle(478300.0, 0.00259) }, { 0.38d, new GammaParticle(10728.0, 0.11557) }, { 0.23399999999999999d, new GammaParticle(63287.0, 0.01959) }, { 0.4d, new GammaParticle(64896.0, 0.01911) }, { 0.135d, new GammaParticle(73637.0, 0.01684) }, { 0.17300000000000001d, new GammaParticle(74510.0, 0.01664) }, { 0.038d, new GammaParticle(75576.0, 0.01641) } } },
            { 2.6e-07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium184() }, { 1.0d, new AlphaParticle(5028602.09) } } },

        };
    }
}
    