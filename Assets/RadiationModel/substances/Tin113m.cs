using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin113m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin113m";
        public override double halfLife { get; } = 1284.0d;
        public override double atomicWeight { get; } = 112.90526d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9109999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin113()), new(0.00501d, new GammaParticle(77000.0, 0.0161)), new(0.058350323711999996d, new GammaParticle(3753.0, 0.33036)), new(0.12685786497535642d, new GammaParticle(25044.0, 0.04951)), new(0.23742815829188924d, new GammaParticle(25271.0, 0.04906)), new(0.0671357533272802d, new GammaParticle(28579.0, 0.04338)), new(0.08036149673275439d, new GammaParticle(28810.0, 0.04304)), new(0.013225743405474197d, new GammaParticle(29107.0, 0.0426)) } },
            { 0.08900000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium113()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0056828547648000004d, new GammaParticle(3571.0, 0.3472)), new(0.018765911513463532d, new GammaParticle(24001.0, 0.05166)), new(0.035208089143458784d, new GammaParticle(24209.0, 0.05121)), new(0.009878602809308974d, new GammaParticle(27367.0, 0.0453)), new(0.01175553734307768d, new GammaParticle(27581.0, 0.04495)), new(0.0018769345337687053d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    