using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium146";
        public override double halfLife { get; } = 4170528.0d;
        public override double atomicWeight { get; } = 145.91832d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium146()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00023449999999999998d, new GammaParticle(76540.0, 0.0162)), new(0.443205d, new GammaParticle(114710.0, 0.01081)), new(0.443205d, new GammaParticle(115510.0, 0.01073)), new(0.469d, new GammaParticle(154570.0, 0.00802)), new(0.0008910999999999999d, new GammaParticle(230510.0, 0.00538)), new(0.00037519999999999996d, new GammaParticle(267800.0, 0.00463)), new(4.6899999999999995e-05d, new GammaParticle(270100.0, 0.00459)), new(0.00046899999999999996d, new GammaParticle(383500.0, 0.00323)), new(0.00081606d, new GammaParticle(421600.0, 0.00294)), new(0.0006565999999999999d, new GammaParticle(576000.0, 0.00215)), new(9.379999999999999e-05d, new GammaParticle(742000.0, 0.00167)), new(0.33014661199078105d, new GammaParticle(6603.0, 0.18777)), new(0.5155561903206808d, new GammaParticle(40901.0, 0.03031)), new(0.9302710038265622d, new GammaParticle(41541.0, 0.02985)), new(0.29307307989471143d, new GammaParticle(47146.0, 0.0263)), new(0.368685934507547d, new GammaParticle(47645.0, 0.02602)), new(0.07561285461283555d, new GammaParticle(48248.0, 0.0257)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    