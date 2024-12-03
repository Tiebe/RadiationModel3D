using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium91m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium91m";
        public override double halfLife { get; } = 198.0d;
        public override double atomicWeight { get; } = 90.91857d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium91()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00027560000000000003d, new GammaParticle(205600.0, 0.00603)), new(0.50668d, new GammaParticle(502900.0, 0.00247)), new(0.014469000000000001d, new GammaParticle(606700.0, 0.00204)), new(0.0371d, new GammaParticle(927600.0, 0.00134)), new(0.024963000000000003d, new GammaParticle(1328400.0, 0.00093)), new(0.024698d, new GammaParticle(1362000.0, 0.00091)), new(0.019557d, new GammaParticle(1430400.0, 0.00087)), new(0.024432999999999996d, new GammaParticle(1534400.0, 0.00081)), new(0.005194d, new GammaParticle(2037400.0, 0.00061)), new(1.8980000000000001d, new GammaParticle(511000.0, 0.00243)), new(0.0015012900796830253d, new GammaParticle(2440.0, 0.50813)), new(0.0075492518940456586d, new GammaParticle(17374.0, 0.07136)), new(0.014387748988080158d, new GammaParticle(17479.0, 0.07093)), new(0.003775293219402242d, new GammaParticle(19681.0, 0.063)), new(0.004356688375190187d, new GammaParticle(19794.0, 0.06264)), new(0.0005813951557879453d, new GammaParticle(19963.0, 0.06211)) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium91()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    