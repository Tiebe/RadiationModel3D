using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium189 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium189";
        public override double halfLife { get; } = 1140480.0d;
        public override double atomicWeight { get; } = 188.95872d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium189() }, { 0.00024d, new GammaParticle(25650.0, 0.04834) }, { 2.4000000000000003e-07d, new GammaParticle(30800.0, 0.04025) }, { 6.78e-05d, new GammaParticle(33310.0, 0.03722) }, { 0.00672d, new GammaParticle(36170.0, 0.03428) }, { 0.0015d, new GammaParticle(56500.0, 0.02194) }, { 0.0006d, new GammaParticle(59050.0, 0.021) }, { 0.012d, new GammaParticle(59050.0, 0.021) }, { 0.0354d, new GammaParticle(69520.0, 0.01783) }, { 0.00384d, new GammaParticle(95230.0, 0.01302) }, { 5.999999999999999e-06d, new GammaParticle(97800.0, 0.01268) }, { 0.000684d, new GammaParticle(138300.0, 0.00896) }, { 0.00108d, new GammaParticle(147100.0, 0.00843) }, { 0.000846d, new GammaParticle(149900.0, 0.00827) }, { 0.000738d, new GammaParticle(164000.0, 0.00756) }, { 0.000294d, new GammaParticle(180500.0, 0.00687) }, { 0.0018d, new GammaParticle(185850.0, 0.00667) }, { 0.000516d, new GammaParticle(188600.0, 0.00657) }, { 0.00264d, new GammaParticle(197400.0, 0.00628) }, { 0.000798d, new GammaParticle(206300.0, 0.00601) }, { 0.0051600000000000005d, new GammaParticle(216700.0, 0.00572) }, { 0.00528d, new GammaParticle(219400.0, 0.00565) }, { 0.003d, new GammaParticle(233500.0, 0.00531) }, { 0.06d, new GammaParticle(245100.0, 0.00506) }, { 0.0054d, new GammaParticle(275800.0, 0.0045) }, { 0.000546d, new GammaParticle(343200.0, 0.00361) }, { 5.999999999999999e-06d, new GammaParticle(369100.0, 0.00336) }, { 6.6e-05d, new GammaParticle(402800.0, 0.00308) }, { 3.6e-05d, new GammaParticle(438500.0, 0.00283) }, { 0.4200283906093968d, new GammaParticle(10393.0, 0.1193) }, { 0.2325832626506913d, new GammaParticle(61486.0, 0.02016) }, { 0.4007983157861301d, new GammaParticle(63000.0, 0.01968) }, { 0.1340987560596708d, new GammaParticle(71496.0, 0.01734) }, { 0.17164640775637863d, new GammaParticle(72338.0, 0.01714) }, { 0.037547651696707825d, new GammaParticle(73364.0, 0.0169) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    