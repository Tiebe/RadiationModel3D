using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ruthenium93m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium93m";
        public override double halfLife { get; } = 10.8d;
        public override double atomicWeight { get; } = 92.91789d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.78d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum93()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0046d, new GammaParticle(642900.0, 0.00193)), new(0.0166d, new GammaParticle(928300.0, 0.00134)), new(0.006999999999999999d, new GammaParticle(1015900.0, 0.00122)), new(0.0069d, new GammaParticle(1023000.0, 0.00121)), new(0.262d, new GammaParticle(1111200.0, 0.00112)), new(0.385d, new GammaParticle(1396200.0, 0.00089)), new(0.092d, new GammaParticle(2039100.0, 0.00061)), new(1.676d, new GammaParticle(511000.0, 0.00243)), new(0.0012d, new GammaParticle(2586.0, 0.47944)), new(0.0057399999999999994d, new GammaParticle(18250.0, 0.06794)), new(0.0109d, new GammaParticle(18367.0, 0.0675)), new(0.0029d, new GammaParticle(20695.0, 0.05991)), new(0.00336d, new GammaParticle(20820.0, 0.05955)), new(0.000458d, new GammaParticle(21003.0, 0.05903)) } },
            { 0.22d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ruthenium93()), new(0.214d, new GammaParticle(734400.0, 0.00169)), new(0.0002714376d, new GammaParticle(2737.0, 0.45299)), new(0.0012006784668821325d, new GammaParticle(19150.0, 0.06474)), new(0.0022783272616359253d, new GammaParticle(19279.0, 0.06431)), new(0.0006122690804491762d, new GammaParticle(21736.0, 0.05704)), new(0.0007114566714819427d, new GammaParticle(21875.0, 0.05668)), new(9.918759103276654e-05d, new GammaParticle(22072.0, 0.05617)) } },
            { 0.00027d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum92()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    