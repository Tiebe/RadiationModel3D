using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium113";
        public override double halfLife { get; } = 2.8d;
        public override double atomicWeight { get; } = 112.91544d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium113() }, { 1.0d, new BetaParticle(-1, 2411500.0) }, { 0.0032640000000000004d, new GammaParticle(34900.0, 0.03553) }, { 0.007344000000000001d, new GammaParticle(79700.0, 0.01556) }, { 0.018768d, new GammaParticle(81300.0, 0.01525) }, { 0.022304d, new GammaParticle(84900.0, 0.0146) }, { 0.004896d, new GammaParticle(96800.0, 0.01281) }, { 0.001904d, new GammaParticle(100400.0, 0.01235) }, { 0.026383999999999998d, new GammaParticle(116800.0, 0.01062) }, { 0.00136d, new GammaParticle(119400.0, 0.01038) }, { 0.005984000000000001d, new GammaParticle(120800.0, 0.01026) }, { 0.007616d, new GammaParticle(135000.0, 0.00918) }, { 0.021216d, new GammaParticle(137500.0, 0.00902) }, { 0.020128d, new GammaParticle(151800.0, 0.00817) }, { 0.015504d, new GammaParticle(157100.0, 0.00789) }, { 0.013056000000000002d, new GammaParticle(159900.0, 0.00775) }, { 0.12240000000000001d, new GammaParticle(189700.0, 0.00654) }, { 0.002448d, new GammaParticle(197000.0, 0.00629) }, { 0.024752d, new GammaParticle(217000.0, 0.00571) }, { 0.028016d, new GammaParticle(219600.0, 0.00565) }, { 0.011696d, new GammaParticle(221000.0, 0.00561) }, { 0.002448d, new GammaParticle(236700.0, 0.00524) }, { 0.018496d, new GammaParticle(252100.0, 0.00492) }, { 0.007344000000000001d, new GammaParticle(257900.0, 0.00481) }, { 0.007616d, new GammaParticle(265500.0, 0.00467) }, { 0.0032640000000000004d, new GammaParticle(310800.0, 0.00399) }, { 0.00544d, new GammaParticle(332700.0, 0.00373) }, { 0.00544d, new GammaParticle(332700.0, 0.00373) }, { 0.00136d, new GammaParticle(339100.0, 0.00366) }, { 0.005712d, new GammaParticle(348500.0, 0.00356) }, { 0.272d, new GammaParticle(348900.0, 0.00355) }, { 0.005712d, new GammaParticle(348900.0, 0.00355) }, { 0.01224d, new GammaParticle(357600.0, 0.00347) }, { 0.004896d, new GammaParticle(373100.0, 0.00332) }, { 0.11478400000000001d, new GammaParticle(409300.0, 0.00303) }, { 0.007616d, new GammaParticle(454700.0, 0.00273) }, { 0.01496d, new GammaParticle(500300.0, 0.00248) }, { 0.019039999999999998d, new GammaParticle(538800.0, 0.0023) }, { 0.010336000000000001d, new GammaParticle(543000.0, 0.00228) }, { 0.018496d, new GammaParticle(609000.0, 0.00204) }, { 0.006256d, new GammaParticle(671100.0, 0.00185) }, { 0.004624d, new GammaParticle(749100.0, 0.00166) }, { 0.010336000000000001d, new GammaParticle(932700.0, 0.00133) }, { 0.00544d, new GammaParticle(980000.0, 0.00127) }, { 0.005168000000000001d, new GammaParticle(1053000.0, 0.00118) }, { 0.0180999943692032d, new GammaParticle(3053.0, 0.40611) }, { 0.05118502263514566d, new GammaParticle(21020.0, 0.05898) }, { 0.09670323566058127d, new GammaParticle(21177.0, 0.05855) }, { 0.026531406338694944d, new GammaParticle(23904.0, 0.05187) }, { 0.031041745416273078d, new GammaParticle(24070.0, 0.05151) }, { 0.0045103390775781405d, new GammaParticle(24297.0, 0.05103) } } },

        };
    }
}
    