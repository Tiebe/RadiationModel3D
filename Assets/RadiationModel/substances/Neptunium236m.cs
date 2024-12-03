using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium236m : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium236m";
        public override double halfLife { get; } = 81000.0d;
        public override double atomicWeight { get; } = 236.04663d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.51d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium236()), new(0.19304026d, new GammaParticle(16678.0, 0.07434)), new(0.10648228063059265d, new GammaParticle(94657.0, 0.0131)), new(0.17045346667295125d, new GammaParticle(98439.0, 0.0126)), new(0.06149541929691213d, new GammaParticle(111238.0, 0.01115)), new(0.08252685269645609d, new GammaParticle(112645.0, 0.01101)), new(0.021031433399543952d, new GammaParticle(114446.0, 0.01083)) } },
            { 0.49d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium236()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0016d, new GammaParticle(44630.0, 0.02778)), new(0.44847679999999995d, new GammaParticle(17604.0, 0.07043)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    