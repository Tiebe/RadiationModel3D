using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium225";
        public override double halfLife { get; } = 525.0d;
        public override double atomicWeight { get; } = 225.02395d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium221()), new(1.0d, new AlphaParticle(7943002.09)), new(0.0012d, new GammaParticle(50500.0, 0.02455)), new(0.009899999999999999d, new GammaParticle(53200.0, 0.02331)), new(0.0049d, new GammaParticle(68800.0, 0.01802)), new(0.009000000000000001d, new GammaParticle(103500.0, 0.01198)), new(0.0012d, new GammaParticle(121900.0, 0.01017)), new(0.0017000000000000001d, new GammaParticle(126400.0, 0.00981)), new(0.0014000000000000002d, new GammaParticle(128900.0, 0.00962)), new(0.0095d, new GammaParticle(146800.0, 0.00845)), new(0.0018d, new GammaParticle(148500.0, 0.00835)), new(0.0060999999999999995d, new GammaParticle(151200.0, 0.0082)), new(0.0038d, new GammaParticle(164000.0, 0.00756)), new(0.0097d, new GammaParticle(177200.0, 0.007)), new(0.0018d, new GammaParticle(212000.0, 0.00585)), new(0.0038d, new GammaParticle(217700.0, 0.0057)), new(0.0506d, new GammaParticle(246000.0, 0.00504)), new(0.0083d, new GammaParticle(299200.0, 0.00414)), new(0.040999999999999995d, new GammaParticle(305900.0, 0.00405)), new(0.225d, new GammaParticle(321400.0, 0.00386)), new(0.040999999999999995d, new GammaParticle(359000.0, 0.00345)), new(0.0034000000000000002d, new GammaParticle(381800.0, 0.00325)), new(0.00068d, new GammaParticle(485400.0, 0.00255)), new(0.223164140597848d, new GammaParticle(14920.0, 0.0831)), new(0.068028825146423d, new GammaParticle(85432.0, 0.01451)), new(0.11112189667824732d, new GammaParticle(88471.0, 0.01401)), new(0.038986866421182015d, new GammaParticle(100119.0, 0.01238)), new(0.05177455860732972d, new GammaParticle(101370.0, 0.01223)), new(0.012787692186147703d, new GammaParticle(102948.0, 0.01204)) } },
            { 0.1d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium225()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    