using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten174 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten174";
        public override double halfLife { get; } = 1992.0d;
        public override double atomicWeight { get; } = 173.94608d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium174() }, { 1.0d, new BetaParticle(1, 2808800.0) }, { 0.15276d, new GammaParticle(35420.0, 0.035) }, { 0.028006000000000003d, new GammaParticle(49840.0, 0.02488) }, { 0.021259100000000003d, new GammaParticle(61900.0, 0.02003) }, { 0.0061104d, new GammaParticle(73360.0, 0.0169) }, { 0.0022914000000000003d, new GammaParticle(75880.0, 0.01634) }, { 0.0112024d, new GammaParticle(96440.0, 0.01286) }, { 0.05091999999999999d, new GammaParticle(125180.0, 0.0099) }, { 0.05091999999999999d, new GammaParticle(136520.0, 0.00908) }, { 0.016421699999999997d, new GammaParticle(143720.0, 0.00863) }, { 0.007638000000000001d, new GammaParticle(162680.0, 0.00762) }, { 0.0058557999999999995d, new GammaParticle(173960.0, 0.00713) }, { 0.021641d, new GammaParticle(181410.0, 0.00683) }, { 0.05346599999999999d, new GammaParticle(193040.0, 0.00642) }, { 0.030552000000000003d, new GammaParticle(202030.0, 0.00614) }, { 0.0072561d, new GammaParticle(216360.0, 0.00573) }, { 0.029279000000000003d, new GammaParticle(233360.0, 0.00531) }, { 0.012348099999999999d, new GammaParticle(239400.0, 0.00518) }, { 0.0100567d, new GammaParticle(289810.0, 0.00428) }, { 0.08911d, new GammaParticle(328680.0, 0.00377) }, { 0.035644d, new GammaParticle(339760.0, 0.00365) }, { 0.021259100000000003d, new GammaParticle(354970.0, 0.00349) }, { 0.036917d, new GammaParticle(364540.0, 0.0034) }, { 0.054739d, new GammaParticle(377070.0, 0.00329) }, { 0.084018d, new GammaParticle(378560.0, 0.00328) }, { 0.008911d, new GammaParticle(400450.0, 0.0031) }, { 0.1273d, new GammaParticle(428840.0, 0.00289) }, { 0.0044555d, new GammaParticle(472240.0, 0.00263) }, { 0.0044555d, new GammaParticle(547510.0, 0.00226) }, { 0.004582800000000001d, new GammaParticle(567570.0, 0.00218) }, { 0.0058557999999999995d, new GammaParticle(834990.0, 0.00148) } } },

        };
    }
}
    