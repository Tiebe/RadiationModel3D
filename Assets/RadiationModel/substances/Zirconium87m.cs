using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zirconium87m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium87m";
        public override double halfLife { get; } = 14.0d;
        public override double atomicWeight { get; } = 86.91518d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium87()), new(0.272d, new GammaParticle(134930.0, 0.00919)), new(0.9640000000000001d, new GammaParticle(201020.0, 0.00617)), new(0.02410299439688d, new GammaParticle(2161.0, 0.57374)), new(0.11983598974932975d, new GammaParticle(15691.0, 0.07902)), new(0.22935117655374118d, new GammaParticle(15775.0, 0.0786)), new(0.05844162172506894d, new GammaParticle(17736.0, 0.06991)), new(0.06697409849692901d, new GammaParticle(17824.0, 0.06956)), new(0.008532476771860064d, new GammaParticle(17968.0, 0.069)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    