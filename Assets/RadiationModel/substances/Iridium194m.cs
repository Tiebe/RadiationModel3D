using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium194m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium194m";
        public override double halfLife { get; } = 0.03185d;
        public override double atomicWeight { get; } = 193.96523d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium194()), new(0.00021999999999999998d, new GammaParticle(27930.0, 0.04439)), new(0.0017000000000000001d, new GammaParticle(29890.0, 0.04148)), new(0.00026d, new GammaParticle(34829.0, 0.0356)), new(0.0014399999999999999d, new GammaParticle(39217.0, 0.03161)), new(0.00018700000000000002d, new GammaParticle(41166.0, 0.03012)), new(0.005699999999999999d, new GammaParticle(43119.0, 0.02875)), new(0.004d, new GammaParticle(62793.0, 0.01974)), new(0.0043d, new GammaParticle(82339.0, 0.01506)), new(0.047d, new GammaParticle(84288.0, 0.01471)), new(0.085d, new GammaParticle(112230.0, 0.01105)), new(0.500306965367d, new GammaParticle(10728.0, 0.11557)), new(0.13302616809891782d, new GammaParticle(63287.0, 0.01959)), new(0.22829272026586203d, new GammaParticle(64896.0, 0.01911)), new(0.07660073081466884d, new GammaParticle(73637.0, 0.01684)), new(0.09827873763522012d, new GammaParticle(74510.0, 0.01664)), new(0.02167800682055128d, new GammaParticle(75576.0, 0.01641)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    