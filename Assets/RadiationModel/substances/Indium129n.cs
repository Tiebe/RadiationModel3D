using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium129n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium129n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 128.92362d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium129()), new(0.92d, new GammaParticle(333800.0, 0.00371)), new(0.7636d, new GammaParticle(359000.0, 0.00345)), new(0.7544d, new GammaParticle(995200.0, 0.00125)), new(0.2576d, new GammaParticle(1354100.0, 0.00092)), new(0.004749604070399999d, new GammaParticle(3571.0, 0.3472)), new(0.015579705713370822d, new GammaParticle(24001.0, 0.05166)), new(0.0292302170982567d, new GammaParticle(24209.0, 0.05121)), new(0.008201345536447458d, new GammaParticle(27367.0, 0.0453)), new(0.009759601188372474d, new GammaParticle(27581.0, 0.04495)), new(0.0015582556519250167d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    