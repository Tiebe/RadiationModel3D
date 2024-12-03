using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium112m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium112m";
        public override double halfLife { get; } = 1240.2d;
        public override double atomicWeight { get; } = 111.90571d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium112()), new(0.1333d, new GammaParticle(156610.0, 0.00792)), new(0.05404984416d, new GammaParticle(3571.0, 0.3472)), new(0.16193428136051483d, new GammaParticle(24001.0, 0.05166)), new(0.3038166629653187d, new GammaParticle(24209.0, 0.05121)), new(0.08524416443207272d, new GammaParticle(27367.0, 0.0453)), new(0.10144055567416654d, new GammaParticle(27581.0, 0.04495)), new(0.016196391242093818d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    