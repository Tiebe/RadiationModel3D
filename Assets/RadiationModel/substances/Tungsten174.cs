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

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium174()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.15276d, new GammaParticle(35420.0, 0.035)), new(0.028006000000000003d, new GammaParticle(49840.0, 0.02488)), new(0.021259100000000003d, new GammaParticle(61900.0, 0.02003)), new(0.0061104d, new GammaParticle(73360.0, 0.0169)), new(0.0022914000000000003d, new GammaParticle(75880.0, 0.01634)), new(0.0112024d, new GammaParticle(96440.0, 0.01286)), new(0.05091999999999999d, new GammaParticle(125180.0, 0.0099)), new(0.05091999999999999d, new GammaParticle(136520.0, 0.00908)), new(0.016421699999999997d, new GammaParticle(143720.0, 0.00863)), new(0.007638000000000001d, new GammaParticle(162680.0, 0.00762)), new(0.0058557999999999995d, new GammaParticle(173960.0, 0.00713)), new(0.021641d, new GammaParticle(181410.0, 0.00683)), new(0.05346599999999999d, new GammaParticle(193040.0, 0.00642)), new(0.030552000000000003d, new GammaParticle(202030.0, 0.00614)), new(0.0072561d, new GammaParticle(216360.0, 0.00573)), new(0.029279000000000003d, new GammaParticle(233360.0, 0.00531)), new(0.012348099999999999d, new GammaParticle(239400.0, 0.00518)), new(0.0100567d, new GammaParticle(289810.0, 0.00428)), new(0.08911d, new GammaParticle(328680.0, 0.00377)), new(0.035644d, new GammaParticle(339760.0, 0.00365)), new(0.021259100000000003d, new GammaParticle(354970.0, 0.00349)), new(0.036917d, new GammaParticle(364540.0, 0.0034)), new(0.054739d, new GammaParticle(377070.0, 0.00329)), new(0.084018d, new GammaParticle(378560.0, 0.00328)), new(0.008911d, new GammaParticle(400450.0, 0.0031)), new(0.1273d, new GammaParticle(428840.0, 0.00289)), new(0.0044555d, new GammaParticle(472240.0, 0.00263)), new(0.0044555d, new GammaParticle(547510.0, 0.00226)), new(0.004582800000000001d, new GammaParticle(567570.0, 0.00218)), new(0.0058557999999999995d, new GammaParticle(834990.0, 0.00148)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    