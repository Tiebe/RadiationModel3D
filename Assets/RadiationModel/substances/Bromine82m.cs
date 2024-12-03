using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bromine82m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine82m";
        public override double halfLife { get; } = 367.8d;
        public override double atomicWeight { get; } = 81.91685d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.976d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bromine82()), new(0.0025d, new GammaParticle(45949.0, 0.02698)), new(0.0187602074d, new GammaParticle(1535.0, 0.80771)), new(0.11511507723491271d, new GammaParticle(11879.0, 0.10437)), new(0.22218698559141614d, new GammaParticle(11925.0, 0.10397)), new(0.05269953320986924d, new GammaParticle(13345.0, 0.09291)), new(0.056767937173671144d, new GammaParticle(13377.0, 0.09268)), new(0.004068403963801905d, new GammaParticle(13469.0, 0.09205)) } },
            { 0.024d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Krypton82()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(2e-05d, new GammaParticle(619090.0, 0.002)), new(0.00034d, new GammaParticle(698370.0, 0.00178)), new(1.76e-05d, new GammaParticle(711200.0, 0.00174)), new(3e-07d, new GammaParticle(735600.0, 0.00169)), new(0.0026d, new GammaParticle(776520.0, 0.0016)), new(2e-05d, new GammaParticle(1072990.0, 0.00116)), new(4.4e-06d, new GammaParticle(1081290.0, 0.00115)), new(3.6000000000000003e-06d, new GammaParticle(1168500.0, 0.00106)), new(5.2e-08d, new GammaParticle(1173400.0, 0.00106)), new(3.9e-05d, new GammaParticle(1180270.0, 0.00105)), new(2.5999999999999997e-06d, new GammaParticle(1180950.0, 0.00105)), new(1.11e-05d, new GammaParticle(1317440.0, 0.00094)), new(5e-07d, new GammaParticle(1395100.0, 0.00089)), new(0.0002d, new GammaParticle(1474880.0, 0.00084)), new(2.9e-06d, new GammaParticle(1703190.0, 0.00073)), new(8.000000000000001e-07d, new GammaParticle(1771000.0, 0.0007)), new(4.1e-06d, new GammaParticle(1879500.0, 0.00066)), new(1.66e-05d, new GammaParticle(1956750.0, 0.00063)), new(2.4e-06d, new GammaParticle(2479600.0, 0.0005)), new(7.3e-07d, new GammaParticle(2656000.0, 0.00047)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    