public class Mailbox {
    public string SerializationData {get;set;} = string.Empty;
    public string RunspaceId {get; set;} = string.Empty;
    public DateTime? Date {get;set;}
    public string Name {get;set;} = string.Empty;
    public string FolderPath {get;set;} = string.Empty;
    public string FolderId {get;set;} = string.Empty;
    public string FolderType {get;set;} = string.Empty;
    public string ContentFolder {get;set;} = string.Empty;
    public string ContentMailboxGuid {get;set;} = string.Empty;
    public string RawContentMailboxGuid {get;set;} = string.Empty;
    public string Movable {get;set;} = string.Empty;
    public string RecoverableItemsFolder {get;set;} = string.Empty;
    public string AssociatedIPMFolderPath {get;set;} = string.Empty;
    public string ContainerClass {get;set;} = string.Empty;
    public string Flags {get;set;} = string.Empty;
    public string TargetQuota {get;set;} = string.Empty;
    public string StorageQuota {get;set;} = string.Empty;
    public string StorageWarningQuota {get;set;} = string.Empty;
    public long ItemsInFolder {get;set;}
    public long DeletedItemsInFolder {get;set;}
    public long FolderSize {get;set;}
    public long ItemsInFolderAndSubfolders {get;set;}
    public long DeletedItemsInFolderAndSubfolders {get;set;}
    public long FolderAndSubfolderSize {get;set;}
    public string CurrentSchemaVersion {get;set;} = string.Empty;
    public string OldestItemReceivedDate {get;set;} = string.Empty;
    public string NewestItemReceivedDate {get;set;} = string.Empty;
    public string OldestDeletedItemReceivedDate {get;set;} = string.Empty;
    public string NewestDeletedItemReceivedDate {get;set;} = string.Empty;
    public string OldestItemLastModifiedDate {get;set;} = string.Empty;
    public string NewestItemLastModifiedDate {get;set;} = string.Empty;
    public string OldestDeletedItemLastModifiedDate {get;set;} = string.Empty;
    public string NewestDeletedItemLastModifiedDate {get;set;} = string.Empty;
    public string ManagedFolder {get;set;} = string.Empty;
    public string DeletePolicy {get;set;} = string.Empty;
    public string ArchivePolicy {get;set;} = string.Empty;
    public string TopSubject {get;set;} = string.Empty;
    public string TopSubjectSize {get;set;} = string.Empty;
    public string TopSubjectCount {get;set;} = string.Empty;
    public string TopSubjectClass {get;set;} = string.Empty;
    public string TopSubjectPath {get;set;} = string.Empty;
    public string TopSubjectReceivedTime {get;set;} = string.Empty;
    public string TopSubjectFrom {get;set;} = string.Empty;
    public string TopClientInfoForSubject {get;set;} = string.Empty;
    public string TopClientInfoCountForSubject {get;set;} = string.Empty;
    public string SearchFolders {get;set;} = string.Empty;
    public string AuditAuxMailboxGuid {get;set;} = string.Empty;
    public string AuditFolderStubSize {get;set;} = string.Empty;
    public string LastMovedTimeStamp {get;set;} = string.Empty;
    public string Identity {get;set;} = string.Empty;
    public string IsValid {get;set;} = string.Empty;
    public string ObjectState {get;set;} = string.Empty;
}