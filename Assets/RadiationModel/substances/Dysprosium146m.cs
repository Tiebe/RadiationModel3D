using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium146m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium146m";
        public override double halfLife { get; } = 0.15d;
        public override double atomicWeight { get; } = 145.93599d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium146()), new(0.02979d, new GammaParticle(127000.0, 0.00976)), new(1.00293d, new GammaParticle(237200.0, 0.00523)), new(0.3972d, new GammaParticle(289700.0, 0.00428)), new(0.53622d, new GammaParticle(416500.0, 0.00298)), new(0.12909d, new GammaParticle(499000.0, 0.00248)), new(0.8937d, new GammaParticle(673700.0, 0.00184)), new(0.993d, new GammaParticle(682900.0, 0.00182)), new(1.0525799999999998d, new GammaParticle(925300.0, 0.00134)), new(0.15888d, new GammaParticle(1100000.0, 0.00113)), new(0.10872478662360001d, new GammaParticle(7384.0, 0.16791)), new(0.0750733549848051d, new GammaParticle(45207.0, 0.02743)), new(0.1341553877498304d, new GammaParticle(45998.0, 0.02695)), new(0.043074552274098774d, new GammaParticle(52220.0, 0.02374)), new(0.054273935865364456d, new GammaParticle(52791.0, 0.02349)), new(0.011199383591265684d, new GammaParticle(53478.0, 0.02318)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    