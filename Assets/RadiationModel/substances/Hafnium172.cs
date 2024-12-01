using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium172";
        public override double halfLife { get; } = 59011451.57249d;
        public override double atomicWeight { get; } = 171.93945d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium172()), new(0.000452d, new GammaParticle(11800.0, 0.10507)), new(0.000113d, new GammaParticle(12410.0, 0.09991)), new(0.000452d, new GammaParticle(19940.0, 0.06218)), new(0.2034d, new GammaParticle(23933.1, 0.0518)), new(0.000113d, new GammaParticle(34600.0, 0.03583)), new(0.0026781d, new GammaParticle(41130.0, 0.03014)), new(3.842e-05d, new GammaParticle(41860.0, 0.02962)), new(0.003164d, new GammaParticle(44170.0, 0.02807)), new(0.000904d, new GammaParticle(48170.0, 0.02574)), new(0.0113d, new GammaParticle(60650.0, 0.02044)), new(0.05311d, new GammaParticle(67350.0, 0.01841)), new(0.006893d, new GammaParticle(68000.0, 0.01823)), new(0.008362000000000001d, new GammaParticle(69990.0, 0.01771)), new(0.000113d, new GammaParticle(73900.0, 0.01678)), new(0.0452d, new GammaParticle(81751.3, 0.01517)), new(0.00113d, new GammaParticle(91300.0, 0.01358)), new(0.025537999999999998d, new GammaParticle(114061.0, 0.01087)), new(0.000339d, new GammaParticle(116100.0, 0.01068)), new(0.011413d, new GammaParticle(122916.0, 0.01009)), new(0.113d, new GammaParticle(125812.0, 0.00985)), new(0.014577d, new GammaParticle(127910.0, 0.00969)), new(0.000226d, new GammaParticle(138100.0, 0.00898)), new(0.000113d, new GammaParticle(142400.0, 0.00871)), new(0.000113d, new GammaParticle(148800.0, 0.00833)), new(0.000113d, new GammaParticle(150400.0, 0.00824)), new(0.001469d, new GammaParticle(154720.0, 0.00801)), new(0.000113d, new GammaParticle(172200.0, 0.0072)), new(0.000113d, new GammaParticle(178500.0, 0.00695)), new(0.000113d, new GammaParticle(198900.0, 0.00623)), new(0.76d, new GammaParticle(8810.0, 0.14073)), new(0.36d, new GammaParticle(52965.0, 0.02341)), new(0.63d, new GammaParticle(54070.0, 0.02293)), new(0.209d, new GammaParticle(61387.0, 0.0202)), new(0.26d, new GammaParticle(62084.0, 0.01997)), new(0.055d, new GammaParticle(62927.0, 0.0197)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    