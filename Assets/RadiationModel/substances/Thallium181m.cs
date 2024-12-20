using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium181m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium181m";
        public override double halfLife { get; } = 0.0014d;
        public override double atomicWeight { get; } = 180.98716d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.996d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium181()) } },
            { 0.004d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold177()), new(1.0d, new AlphaParticle(8180002.09)), new(0.0024d, new GammaParticle(241500.0, 0.00513)), new(0.000400091664d, new GammaParticle(11419.0, 0.10858)), new(0.00033125757016251806d, new GammaParticle(66991.0, 0.01851)), new(0.0005639386621765714d, new GammaParticle(68806.0, 0.01802)), new(0.00019028996715353804d, new GammaParticle(78048.0, 0.01589)), new(0.0002452837676609105d, new GammaParticle(78983.0, 0.0157)), new(5.499380050737249e-05d, new GammaParticle(80133.0, 0.01547)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    