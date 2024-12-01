using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium255";
        public override double halfLife { get; } = 1620.0d;
        public override double atomicWeight { get; } = 255.09108d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.93d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium255()), new(0.023d, new GammaParticle(169600.0, 0.00731)), new(0.033d, new GammaParticle(231400.0, 0.00536)), new(0.37625639977799996d, new GammaParticle(20618.0, 0.06013)), new(0.18075198795296207d, new GammaParticle(115320.0, 0.01075)), new(0.2764637319561977d, new GammaParticle(121090.0, 0.01024)), new(0.10791635741973549d, new GammaParticle(136318.0, 0.0091)), new(0.14676624609084027d, new GammaParticle(138067.0, 0.00898)), new(0.038849888671104775d, new GammaParticle(140406.0, 0.00883)) } },
            { 0.07d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium251()), new(1.0d, new AlphaParticle(8927002.09)), new(0.053d, new GammaParticle(405350.0, 0.00306)), new(0.07d, new GammaParticle(452900.0, 0.00274)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    