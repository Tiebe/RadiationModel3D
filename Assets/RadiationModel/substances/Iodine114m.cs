using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine114m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine114m";
        public override double halfLife { get; } = 6.2d;
        public override double atomicWeight { get; } = 113.9223d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.91d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony114()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0055000000000000005d, new GammaParticle(310700.0, 0.00399)), new(0.0036d, new GammaParticle(403300.0, 0.00307)), new(0.036000000000000004d, new GammaParticle(543000.0, 0.00228)), new(0.0091d, new GammaParticle(558400.0, 0.00222)), new(0.073d, new GammaParticle(635600.0, 0.00195)), new(0.31d, new GammaParticle(682500.0, 0.00182)), new(0.91d, new GammaParticle(708800.0, 0.00175)), new(0.0073d, new GammaParticle(733700.0, 0.00169)), new(0.0073d, new GammaParticle(758200.0, 0.00164)), new(0.146d, new GammaParticle(774900.0, 0.0016)), new(0.01d, new GammaParticle(792100.0, 0.00157)), new(0.025d, new GammaParticle(850400.0, 0.00146)), new(0.0027d, new GammaParticle(860400.0, 0.00144)), new(0.0036d, new GammaParticle(939000.0, 0.00132)), new(0.035d, new GammaParticle(1085600.0, 0.00114)), new(0.0036d, new GammaParticle(1194300.0, 0.00104)), new(0.0027d, new GammaParticle(1211000.0, 0.00102)), new(0.013999999999999999d, new GammaParticle(1219600.0, 0.00102)), new(0.0018d, new GammaParticle(1248800.0, 0.00099)), new(0.038d, new GammaParticle(1303800.0, 0.00095)), new(0.0027d, new GammaParticle(1353700.0, 0.00092)), new(0.0018d, new GammaParticle(1391000.0, 0.00089)), new(0.0073d, new GammaParticle(1446100.0, 0.00086)), new(0.0064d, new GammaParticle(1559700.0, 0.00079)), new(0.015d, new GammaParticle(1568200.0, 0.00079)), new(0.013000000000000001d, new GammaParticle(1606600.0, 0.00077)), new(0.018000000000000002d, new GammaParticle(1659600.0, 0.00075)), new(0.0036d, new GammaParticle(1680500.0, 0.00074)), new(0.0055000000000000005d, new GammaParticle(1698400.0, 0.00073)), new(0.009000000000000001d, new GammaParticle(1753600.0, 0.00071)), new(0.0036d, new GammaParticle(1767500.0, 0.0007)), new(0.0036d, new GammaParticle(1793400.0, 0.00069)), new(0.008d, new GammaParticle(1817900.0, 0.00068)), new(0.024d, new GammaParticle(1862400.0, 0.00067)), new(0.0046d, new GammaParticle(1986300.0, 0.00062)), new(0.009000000000000001d, new GammaParticle(2435100.0, 0.00051)), new(0.0036d, new GammaParticle(2762800.0, 0.00045)), new(0.0018d, new GammaParticle(3321100.0, 0.00037)), new(0.0009d, new GammaParticle(3851800.0, 0.00032)), new(0.0009d, new GammaParticle(3912700.0, 0.00032)) } },
            { 0.09d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine114()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    