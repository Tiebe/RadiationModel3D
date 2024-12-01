using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Plutonium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium242";
        public override double halfLife { get; } = 11770733388522.816d;
        public override double atomicWeight { get; } = 242.05874d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium238()), new(1.0d, new AlphaParticle(6006202.09)), new(0.00038399999999999996d, new GammaParticle(44915.0, 0.0276)), new(0.00025299999999999997d, new GammaParticle(103500.0, 0.01198)), new(2.2e-06d, new GammaParticle(159018.0, 0.0078)), new(0.08648762234059999d, new GammaParticle(16678.0, 0.07434)), new(1.3211871292014275e-07d, new GammaParticle(94657.0, 0.0131)), new(2.1149145657138268e-07d, new GammaParticle(98439.0, 0.0126)), new(7.630091692136704e-08d, new GammaParticle(111238.0, 0.01115)), new(1.0239583050847457e-07d, new GammaParticle(112645.0, 0.01101)), new(2.6094913587107525e-08d, new GammaParticle(114446.0, 0.01083)) } },
            { 5.5299999999999996e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    