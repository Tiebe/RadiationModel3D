using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium238";
        public override double halfLife { get; } = 1.4099634525447706e+17d;
        public override double atomicWeight { get; } = 238.05079d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium234() }, { 1.0d, new AlphaParticle(5291702.09) }, { 0.00064d, new GammaParticle(49550.0, 0.02502) }, { 0.00010200000000000001d, new GammaParticle(113500.0, 0.01092) }, { 0.073226196218728d, new GammaParticle(15784.0, 0.07855) }, { 6.9156789305651295e-06d, new GammaParticle(89954.0, 0.01378) }, { 1.1186798658306582e-05d, new GammaParticle(93347.0, 0.01328) }, { 3.9806495221602725e-06d, new GammaParticle(105566.0, 0.01174) }, { 5.322128411128284e-06d, new GammaParticle(106894.0, 0.0116) }, { 1.3414788889680118e-06d, new GammaParticle(108580.0, 0.01142) } } },
            { 5.450000000000001e-07d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    