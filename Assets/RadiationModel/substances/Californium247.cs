using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Californium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium247";
        public override double halfLife { get; } = 11196.0d;
        public override double atomicWeight { get; } = 247.07097d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99965d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium247()), new(0.0024d, new GammaParticle(29900.0, 0.04147)), new(1.9e-05d, new GammaParticle(40800.0, 0.03039)), new(0.00181d, new GammaParticle(42000.0, 0.02952)), new(0.0102d, new GammaParticle(294100.0, 0.00422)), new(9.3e-05d, new GammaParticle(305200.0, 0.00406)), new(0.00029d, new GammaParticle(334900.0, 0.0037)), new(6.2e-05d, new GammaParticle(337300.0, 0.00368)), new(0.000114d, new GammaParticle(363900.0, 0.00341)), new(0.00074d, new GammaParticle(376200.0, 0.0033)), new(0.002d, new GammaParticle(407000.0, 0.00305)), new(0.0034999999999999996d, new GammaParticle(417900.0, 0.00297)), new(0.005699999999999999d, new GammaParticle(447800.0, 0.00277)), new(0.000114d, new GammaParticle(459500.0, 0.0027)), new(0.9061164923451731d, new GammaParticle(19075.0, 0.065)), new(0.1989109140741887d, new GammaParticle(107218.0, 0.01156)), new(0.3096371638763834d, new GammaParticle(112150.0, 0.01106)), new(0.11680831037121708d, new GammaParticle(126449.0, 0.00981)), new(0.15815845224262792d, new GammaParticle(128067.0, 0.00968)), new(0.041350141871410846d, new GammaParticle(130195.0, 0.00952)) } },
            { 0.00035000000000000005d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium243()), new(1.0d, new AlphaParticle(7524102.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    