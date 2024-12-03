using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhodium116m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium116m";
        public override double halfLife { get; } = 0.57d;
        public override double atomicWeight { get; } = 115.92427d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium116()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00968d, new GammaParticle(172400.0, 0.00719)), new(0.0132d, new GammaParticle(269500.0, 0.0046)), new(0.0308d, new GammaParticle(287700.0, 0.00431)), new(0.02904d, new GammaParticle(293200.0, 0.00423)), new(0.16808d, new GammaParticle(328400.0, 0.00378)), new(0.88d, new GammaParticle(340300.0, 0.00364)), new(0.16896d, new GammaParticle(397700.0, 0.00312)), new(0.0088d, new GammaParticle(420500.0, 0.00295)), new(0.01056d, new GammaParticle(437100.0, 0.00284)), new(0.02376d, new GammaParticle(453000.0, 0.00274)), new(0.034319999999999996d, new GammaParticle(465800.0, 0.00266)), new(0.11263999999999999d, new GammaParticle(466100.0, 0.00266)), new(0.02552d, new GammaParticle(495500.0, 0.0025)), new(0.46552d, new GammaParticle(537300.0, 0.00231)), new(0.0176d, new GammaParticle(553500.0, 0.00224)), new(0.022000000000000002d, new GammaParticle(557400.0, 0.00222)), new(0.0264d, new GammaParticle(609400.0, 0.00203)), new(0.07216d, new GammaParticle(620900.0, 0.002)), new(0.07656d, new GammaParticle(628900.0, 0.00197)), new(0.07304000000000001d, new GammaParticle(635300.0, 0.00195)), new(0.17071999999999998d, new GammaParticle(638700.0, 0.00194)), new(0.09768d, new GammaParticle(652000.0, 0.0019)), new(0.13992000000000002d, new GammaParticle(681400.0, 0.00182)), new(0.01672d, new GammaParticle(714500.0, 0.00174)), new(0.24552d, new GammaParticle(725900.0, 0.00171)), new(0.01056d, new GammaParticle(728000.0, 0.0017)), new(0.11616d, new GammaParticle(737800.0, 0.00168)), new(0.22440000000000002d, new GammaParticle(743600.0, 0.00167)), new(0.01056d, new GammaParticle(773400.0, 0.0016)), new(0.00968d, new GammaParticle(784400.0, 0.00158)), new(0.08448d, new GammaParticle(876500.0, 0.00141)), new(0.00528d, new GammaParticle(886500.0, 0.0014)), new(0.00528d, new GammaParticle(889500.0, 0.00139)), new(0.01232d, new GammaParticle(899000.0, 0.00138)), new(0.01232d, new GammaParticle(942500.0, 0.00132)), new(0.043120000000000006d, new GammaParticle(957000.0, 0.0013)), new(0.01056d, new GammaParticle(1044200.0, 0.00119)), new(0.011439999999999999d, new GammaParticle(1058700.0, 0.00117)), new(0.007039999999999999d, new GammaParticle(1095300.0, 0.00113)), new(0.19976d, new GammaParticle(1104700.0, 0.00112)), new(0.01232d, new GammaParticle(1159000.0, 0.00107)), new(0.00616d, new GammaParticle(1253500.0, 0.00099)), new(0.0088d, new GammaParticle(1437700.0, 0.00086)), new(0.01848d, new GammaParticle(1455500.0, 0.00085)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    