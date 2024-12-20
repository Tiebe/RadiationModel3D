using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum179 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum179";
        public override double halfLife { get; } = 57433605.27376d;
        public override double atomicWeight { get; } = 178.94594d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium179()), new(0.20222748d, new GammaParticle(9114.0, 0.13604)), new(0.12619503663530635d, new GammaParticle(54608.0, 0.0227)), new(0.22085235672962258d, new GammaParticle(55786.0, 0.02222)), new(0.0728607787174989d, new GammaParticle(63333.0, 0.01958)), new(0.09231460663507109d, new GammaParticle(64057.0, 0.01936)), new(0.019453827917572206d, new GammaParticle(64935.0, 0.01909)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    