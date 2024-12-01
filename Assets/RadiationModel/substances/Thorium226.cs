using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium226";
        public override double halfLife { get; } = 1834.2d;
        public override double atomicWeight { get; } = 226.0249d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium222()), new(1.0d, new AlphaParticle(7475002.09)), new(3.3e-07d, new GammaParticle(75130.0, 0.0165)), new(0.0311d, new GammaParticle(111150.0, 0.01115)), new(0.0027d, new GammaParticle(131040.0, 0.00946)), new(2.02e-06d, new GammaParticle(172300.0, 0.0072)), new(0.00111d, new GammaParticle(190310.0, 0.00651)), new(0.00191d, new GammaParticle(206250.0, 0.00601)), new(0.00866d, new GammaParticle(242140.0, 0.00512)), new(2.9e-06d, new GammaParticle(672020.0, 0.00184)), new(5e-07d, new GammaParticle(707520.0, 0.00175)), new(7e-08d, new GammaParticle(722900.0, 0.00172)), new(5.6e-07d, new GammaParticle(783000.0, 0.00158)), new(3.7e-07d, new GammaParticle(802700.0, 0.00154)), new(3.3e-07d, new GammaParticle(913900.0, 0.00136)), new(0.0002d, new GammaParticle(929500.0, 0.00133)), new(3.6e-08d, new GammaParticle(1025020.0, 0.00121)), new(0.06420989389826343d, new GammaParticle(14920.0, 0.0831)), new(0.002955757419601672d, new GammaParticle(85432.0, 0.01451)), new(0.004828091178702501d, new GammaParticle(88471.0, 0.01401)), new(0.0016939248832152907d, new GammaParticle(100119.0, 0.01238)), new(0.002249532244909906d, new GammaParticle(101370.0, 0.01223)), new(0.0005556073616946153d, new GammaParticle(102948.0, 0.01204)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    