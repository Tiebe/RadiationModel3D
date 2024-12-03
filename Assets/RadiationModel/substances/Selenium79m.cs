using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Selenium79m : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium79m";
        public override double halfLife { get; } = 235.2d;
        public override double atomicWeight { get; } = 78.9186d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99944d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Selenium79()), new(0.09539999999999998d, new GammaParticle(95730.0, 0.01295)), new(0.01774097514d, new GammaParticle(1426.0, 0.86945)), new(0.12203674152099404d, new GammaParticle(11183.0, 0.11087)), new(0.2365970172954518d, new GammaParticle(11223.0, 0.11047)), new(0.05521099146331575d, new GammaParticle(12546.0, 0.09882)), new(0.058313849183554096d, new GammaParticle(12571.0, 0.09863)), new(0.003102857720238345d, new GammaParticle(12652.0, 0.098)) } },
            { 0.0005600000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bromine79()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    