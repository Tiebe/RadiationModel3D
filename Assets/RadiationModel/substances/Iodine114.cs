using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine114 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine114";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 113.92202d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony114()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0028079999999999997d, new GammaParticle(310700.0, 0.00399)), new(0.001872d, new GammaParticle(403300.0, 0.00307)), new(0.00468d, new GammaParticle(558400.0, 0.00222)), new(0.006552d, new GammaParticle(639400.0, 0.00194)), new(0.07956d, new GammaParticle(682500.0, 0.00182)), new(0.46799999999999997d, new GammaParticle(708800.0, 0.00175)), new(0.001872d, new GammaParticle(774900.0, 0.0016)), new(0.0014039999999999999d, new GammaParticle(860400.0, 0.00144)), new(0.001872d, new GammaParticle(939000.0, 0.00132)), new(0.017784d, new GammaParticle(1085600.0, 0.00114)), new(0.017316d, new GammaParticle(1091100.0, 0.00114)), new(0.007488d, new GammaParticle(1151200.0, 0.00108)), new(0.007019999999999999d, new GammaParticle(1219600.0, 0.00102)), new(0.000936d, new GammaParticle(1248800.0, 0.00099)), new(0.0014039999999999999d, new GammaParticle(1353700.0, 0.00092)), new(0.000936d, new GammaParticle(1391000.0, 0.00089)), new(0.003276d, new GammaParticle(1446100.0, 0.00086)), new(0.003276d, new GammaParticle(1559700.0, 0.00079)), new(0.007956d, new GammaParticle(1568200.0, 0.00079)), new(0.007956d, new GammaParticle(1587400.0, 0.00078)), new(0.006552d, new GammaParticle(1606600.0, 0.00077)), new(0.001872d, new GammaParticle(1680500.0, 0.00074)), new(0.0028079999999999997d, new GammaParticle(1698400.0, 0.00073)), new(0.00468d, new GammaParticle(1753600.0, 0.00071)), new(0.001872d, new GammaParticle(1767500.0, 0.0007)), new(0.001872d, new GammaParticle(1793400.0, 0.00069)), new(0.007019999999999999d, new GammaParticle(2159100.0, 0.00057)), new(0.014039999999999999d, new GammaParticle(2299400.0, 0.00054)), new(0.001872d, new GammaParticle(2762800.0, 0.00045)), new(0.000936d, new GammaParticle(3321100.0, 0.00037)), new(0.000468d, new GammaParticle(3851800.0, 0.00032)), new(0.000468d, new GammaParticle(3912700.0, 0.00032)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    