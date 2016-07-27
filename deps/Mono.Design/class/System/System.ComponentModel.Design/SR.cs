﻿using System;
using System.Globalization;

namespace Mono.Design
{
	internal static class SR
	{
		//
		// Static Fields
		//
		public const string AlternationCantCapture = "Alternation conditions do not capture and cannot be named.";

		public const string net_log_cache_removed_existing_based_on_policy = "net_log_cache_removed_existing_based_on_policy";

		public const string net_log_cache_removed_existing_based_on_method = "net_log_cache_removed_existing_based_on_method";

		public const string net_log_cache_removed_entry_because_ftp_restart_response_changed = "net_log_cache_removed_entry_because_ftp_restart_response_changed";

		public const string net_log_cache_refused_server_response = "net_log_cache_refused_server_response";

		public const string net_log_cache_range_request_range = "net_log_cache_range_request_range";

		public const string net_log_cache_range_not_in_cache = "net_log_cache_range_not_in_cache";

		public const string net_log_cache_policy_max_stale = "net_log_cache_policy_max_stale";

		public const string net_log_cache_policy_min_fresh = "net_log_cache_policy_min_fresh";

		public const string net_log_cache_post_resp_without_cache_control_or_expires = "net_log_cache_post_resp_without_cache_control_or_expires";

		public const string net_log_cache_range = "net_log_cache_range";

		public const string net_log_cache_range_in_cache = "net_log_cache_range_in_cache";

		public const string net_log_cache_range_invalid_format = "net_log_cache_range_invalid_format";

		public const string net_log_cache_removed_existing_invalid_entry = "net_log_cache_removed_existing_invalid_entry";

		public const string net_log_cache_resp_cache_control_is_private = "net_log_cache_resp_cache_control_is_private";

		public const string net_log_cache_resp_cache_control_is_private_plus_headers = "net_log_cache_resp_cache_control_is_private_plus_headers";

		public const string net_log_cache_resp_cache_control_is_public = "net_log_cache_resp_cache_control_is_public";

		public const string net_log_cache_resp_no_cache_control = "net_log_cache_resp_no_cache_control";

		public const string net_log_cache_resp_older_than_cache = "net_log_cache_resp_older_than_cache";

		public const string net_log_cache_resp_status = "net_log_cache_resp_status";

		public const string net_log_cache_resp_cache_control_is_no_store = "net_log_cache_resp_cache_control_is_no_store";

		public const string net_log_cache_replacing_entry_with_HTTP_200 = "net_log_cache_replacing_entry_with_HTTP_200";

		public const string net_log_cache_request_contains_conditional_header = "net_log_cache_request_contains_conditional_header";

		public const string net_log_cache_request_method = "net_log_cache_request_method";

		public const string net_log_cache_requested_combined_but_null_cached_stream = "net_log_cache_requested_combined_but_null_cached_stream";

		public const string net_log_cache_resp_304_or_request_head = "net_log_cache_resp_304_or_request_head";

		public const string net_log_cache_resp_allows_caching = "net_log_cache_resp_allows_caching";

		public const string net_log_cache_policy_max_age = "net_log_cache_policy_max_age";

		public const string net_log_cache_no_cache_entry = "net_log_cache_no_cache_entry";

		public const string net_log_cache_no_commit = "net_log_cache_no_commit";

		public const string net_log_cache_no_headers_in_metadata = "net_log_cache_no_headers_in_metadata";

		public const string net_log_cache_no_http_response_header = "net_log_cache_no_http_response_header";

		public const string net_log_cache_no_max_age_use_10_percent = "net_log_cache_no_max_age_use_10_percent";

		public const string net_log_cache_no_max_age_use_default = "net_log_cache_no_max_age_use_default";

		public const string net_log_cache_needs_revalidation = "net_log_cache_needs_revalidation";

		public const string net_log_cache_max_age_expires_date = "net_log_cache_max_age_expires_date";

		public const string net_log_cache_max_stale = "net_log_cache_max_stale";

		public const string net_log_cache_max_stale_and_update_status = "net_log_cache_max_stale_and_update_status";

		public const string net_log_cache_metadata_name_value_parse_error = "net_log_cache_metadata_name_value_parse_error";

		public const string net_log_cache_multiple_complex_range_not_implemented = "net_log_cache_multiple_complex_range_not_implemented";

		public const string net_log_cache_need_to_remove_invalid_cache_entry_304 = "net_log_cache_need_to_remove_invalid_cache_entry_304";

		public const string net_log_cache_not_a_get_head_post = "net_log_cache_not_a_get_head_post";

		public const string net_log_cache_object_and_exception = "net_log_cache_object_and_exception";

		public const string net_log_cache_only_byte_range_implemented = "net_log_cache_only_byte_range_implemented";

		public const string net_log_cache_partial_and_non_zero_content_offset = "net_log_cache_partial_and_non_zero_content_offset";

		public const string net_log_cache_partial_resp = "net_log_cache_partial_resp";

		public const string net_log_cache_partial_resp_not_combined_with_existing_entry = "net_log_cache_partial_resp_not_combined_with_existing_entry";

		public const string net_log_cache_policy_cache_sync_date = "net_log_cache_policy_cache_sync_date";

		public const string net_log_cache_null_response_failure = "net_log_cache_null_response_failure";

		public const string net_log_cache_not_updated_based_on_cache_protocol_status = "net_log_cache_not_updated_based_on_cache_protocol_status";

		public const string net_log_cache_not_updated_based_on_ftp_response_status = "net_log_cache_not_updated_based_on_ftp_response_status";

		public const string net_log_cache_not_updated_based_on_policy = "net_log_cache_not_updated_based_on_policy";

		public const string net_log_cache_not_updated_because_no_response = "net_log_cache_not_updated_because_no_response";

		public const string net_log_cache_now_time = "net_log_cache_now_time";

		public const string net_log_cache_null_cached_stream = "net_log_cache_null_cached_stream";

		public const string net_log_cache_resp_status_304 = "net_log_cache_resp_status_304";

		public const string net_log_cache_vary_header_mismatched_field = "net_log_cache_vary_header_mismatched_field";

		public const string net_log_cert_is_of_type_2 = "net_log_cert_is_of_type_2";

		public const string net_log_closed_idle = "net_log_closed_idle";

		public const string net_log_did_not_find_cert_in_store = "net_log_did_not_find_cert_in_store";

		public const string net_log_digest_hash_algorithm_not_supported = "net_log_digest_hash_algorithm_not_supported";

		public const string net_log_digest_qop_not_supported = "net_log_digest_qop_not_supported";

		public const string net_log_cache_vary_header_mismatched_count = "net_log_cache_vary_header_mismatched_count";

		public const string net_log_cache_valid_based_on_status_code = "net_log_cache_valid_based_on_status_code";

		public const string net_log_cache_validation_failed_resubmit = "net_log_cache_validation_failed_resubmit";

		public const string net_log_cache_validator_invalid_for_policy = "net_log_cache_validator_invalid_for_policy";

		public const string net_log_cache_vary_header_contains_asterisks = "net_log_cache_vary_header_contains_asterisks";

		public const string net_log_cache_vary_header_empty = "net_log_cache_vary_header_empty";

		public const string net_log_cache_vary_header_match = "net_log_cache_vary_header_match";

		public const string net_log_digest_requires_nonce = "net_log_digest_requires_nonce";

		public const string net_log_listener_cant_convert_raw_path = "net_log_listener_cant_convert_raw_path";

		public const string net_log_listener_cant_convert_to_utf8 = "net_log_listener_cant_convert_to_utf8";

		public const string net_log_listener_cant_create_uri = "net_log_listener_cant_create_uri";

		public const string net_log_listener_cbt = "net_log_listener_cbt";

		public const string net_log_listener_create_valid_identity_failed = "net_log_listener_create_valid_identity_failed";

		public const string net_log_listener_delegate_exception = "net_log_listener_delegate_exception";

		public const string net_log_listener_cant_convert_percent_value = "net_log_listener_cant_convert_percent_value";

		public const string net_log_exception = "net_log_exception";

		public const string net_log_exception_in_callback = "net_log_exception_in_callback";

		public const string net_log_finding_matching_certs = "net_log_finding_matching_certs";

		public const string net_log_found_cert_in_store = "net_log_found_cert_in_store";

		public const string net_log_got_certificate_from_delegate = "net_log_got_certificate_from_delegate";

		public const string net_log_listener_cant_convert_bytes = "net_log_listener_cant_convert_bytes";

		public const string net_log_cache_valid_as_fresh_or_because_policy = "net_log_cache_valid_as_fresh_or_because_policy";

		public const string net_log_cache_saving_request_headers = "net_log_cache_saving_request_headers";

		public const string net_log_cache_server_didnt_satisfy_range = "net_log_cache_server_didnt_satisfy_range";

		public const string net_log_cache_set_expires = "net_log_cache_set_expires";

		public const string net_log_cache_set_last_modified = "net_log_cache_set_last_modified";

		public const string net_log_cache_set_last_synchronized = "net_log_cache_set_last_synchronized";

		public const string net_log_cache_status_code_not_304_206 = "net_log_cache_status_code_not_304_206";

		public const string net_log_cache_revalidation_required = "net_log_cache_revalidation_required";

		public const string net_log_cache_resp_valid_based_on_retry = "net_log_cache_resp_valid_based_on_retry";

		public const string net_log_cache_response_last_modified = "net_log_cache_response_last_modified";

		public const string net_log_cache_response_valid_based_on_policy = "net_log_cache_response_valid_based_on_policy";

		public const string net_log_cache_result = "net_log_cache_result";

		public const string net_log_cache_returned_range_cache = "net_log_cache_returned_range_cache";

		public const string net_log_cache_revalidation_not_needed = "net_log_cache_revalidation_not_needed";

		public const string net_log_cache_stream = "net_log_cache_stream";

		public const string net_log_cache_update_not_supported_for_ftp_restart = "net_log_cache_update_not_supported_for_ftp_restart";

		public const string net_log_cache_updating_headers_on_304 = "net_log_cache_updating_headers_on_304";

		public const string net_log_cache_updating_last_synchronized = "net_log_cache_updating_last_synchronized";

		public const string net_log_cache_uri_with_query_and_cached_resp_from_http_10 = "net_log_cache_uri_with_query_and_cached_resp_from_http_10";

		public const string net_log_cache_uri_with_query_has_no_expiration = "net_log_cache_uri_with_query_has_no_expiration";

		public const string net_log_cache_usecount_file = "net_log_cache_usecount_file";

		public const string net_log_cache_update_failed = "net_log_cache_update_failed";

		public const string net_log_cache_suppress_update_because_synched_last_minute = "net_log_cache_suppress_update_because_synched_last_minute";

		public const string net_log_cache_suppressing_headers_update_on_304 = "net_log_cache_suppressing_headers_update_on_304";

		public const string net_log_cache_sxx_resp_cache_only = "net_log_cache_sxx_resp_cache_only";

		public const string net_log_cache_sxx_resp_can_be_replaced = "net_log_cache_sxx_resp_can_be_replaced";

		public const string net_log_cache_unexpected_status = "net_log_cache_unexpected_status";

		public const string net_log_cache_update_cached_headers = "net_log_cache_update_cached_headers";

		public const string net_log_cache_max_age_cache_s_max_age = "net_log_cache_max_age_cache_s_max_age";

		public const string net_log_cache_304_head_resp_has_different_last_modified = "net_log_cache_304_head_resp_has_different_last_modified";

		public const string net_log_cache_304_received_on_unconditional_request = "net_log_cache_304_received_on_unconditional_request";

		public const string net_log_cache_304_received_on_unconditional_request_expected_200_206 = "net_log_cache_304_received_on_unconditional_request_expected_200_206";

		public const string net_log_cache_accept_based_on_retry_count = "net_log_cache_accept_based_on_retry_count";

		public const string net_log_cache_after_validation = "net_log_cache_after_validation";

		public const string net_log_cache_age1 = "net_log_cache_age1";

		public const string net_log_cache_206_resp_starting_position_not_adjusted = "net_log_cache_206_resp_starting_position_not_adjusted";

		public const string net_listener_scheme = "net_listener_scheme";

		public const string net_listener_slash = "net_listener_slash";

		public const string net_log_attempting_restart_using_cert = "net_log_attempting_restart_using_cert";

		public const string net_log_auth_invalid_challenge = "net_log_auth_invalid_challenge";

		public const string net_log_buffered_n_bytes = "net_log_buffered_n_bytes";

		public const string net_log_cache_206_resp_non_matching_entry = "net_log_cache_206_resp_non_matching_entry";

		public const string net_log_cache_age1_date_header = "net_log_cache_age1_date_header";

		public const string net_log_cache_cached_auth_header = "net_log_cache_cached_auth_header";

		public const string net_log_cache_cached_auth_header_no_control_directive = "net_log_cache_cached_auth_header_no_control_directive";

		public const string net_log_cache_cannot_construct_conditional_range_request = "net_log_cache_cannot_construct_conditional_range_request";

		public const string net_log_cache_cannot_construct_conditional_request = "net_log_cache_cannot_construct_conditional_request";

		public const string net_log_cache_cannot_remove = "net_log_cache_cannot_remove";

		public const string net_log_cache_cannot_update_cache_if_304 = "net_log_cache_cannot_update_cache_if_304";

		public const string net_log_cache_cache_last_modified = "net_log_cache_cache_last_modified";

		public const string net_log_cache_age1_last_synchronized = "net_log_cache_age1_last_synchronized";

		public const string net_log_cache_age1_last_synchronized_age_header = "net_log_cache_age1_last_synchronized_age_header";

		public const string net_log_cache_age2 = "net_log_cache_age2";

		public const string net_log_cache_auth_header_and_no_s_max_age = "net_log_cache_auth_header_and_no_s_max_age";

		public const string net_log_cache_cache_control = "net_log_cache_cache_control";

		public const string net_log_cache_cache_control_error = "net_log_cache_cache_control_error";

		public const string net_listener_no_spns = "net_listener_no_spns";

		public const string net_io_read = "net_io_read";

		public const string net_io_readfailure = "net_io_readfailure";

		public const string net_io_timeout_use_ge_zero = "net_io_timeout_use_ge_zero";

		public const string net_io_timeout_use_gt_zero = "net_io_timeout_use_gt_zero";

		public const string net_io_transportfailure = "net_io_transportfailure";

		public const string net_io_write = "net_io_write";

		public const string net_io_out_range = "net_io_out_range";

		public const string net_io_header_id = "net_io_header_id";

		public const string net_io_invalidasyncresult = "net_io_invalidasyncresult";

		public const string net_io_invalidendcall = "net_io_invalidendcall";

		public const string net_io_invalidnestedcall = "net_io_invalidnestedcall";

		public const string net_io_must_be_rw_stream = "net_io_must_be_rw_stream";

		public const string net_io_notenoughbyteswritten = "net_io_notenoughbyteswritten";

		public const string net_io_writefailure = "net_io_writefailure";

		public const string net_listener_close_urlgroup_error = "net_listener_close_urlgroup_error";

		public const string net_listener_detach_error = "net_listener_detach_error";

		public const string net_listener_host = "net_listener_host";

		public const string net_listener_invalid_cbt_type = "net_listener_invalid_cbt_type";

		public const string net_listener_mustcall = "net_listener_mustcall";

		public const string net_listener_mustcompletecall = "net_listener_mustcompletecall";

		public const string net_listener_cbt_not_supported = "net_listener_cbt_not_supported";

		public const string net_ipv4_not_installed = "net_ipv4_not_installed";

		public const string net_ipv6_not_installed = "net_ipv6_not_installed";

		public const string net_jscript_load = "net_jscript_load";

		public const string net_listener_already = "net_listener_already";

		public const string net_listener_callinprogress = "net_listener_callinprogress";

		public const string net_listener_cannot_set_custom_cbt = "net_listener_cannot_set_custom_cbt";

		public const string net_log_cache_cannot_update_cache_with_head_resp = "net_log_cache_cannot_update_cache_with_head_resp";

		public const string net_log_cache_ftp_proxy_doesnt_support_partial = "net_log_cache_ftp_proxy_doesnt_support_partial";

		public const string net_log_cache_ftp_response_status = "net_log_cache_ftp_response_status";

		public const string net_log_cache_ftp_supports_bin_only = "net_log_cache_ftp_supports_bin_only";

		public const string net_log_cache_head_resp_has_different_content_length = "net_log_cache_head_resp_has_different_content_length";

		public const string net_log_cache_head_resp_has_different_content_md5 = "net_log_cache_head_resp_has_different_content_md5";

		public const string net_log_cache_head_resp_has_different_etag = "net_log_cache_head_resp_has_different_etag";

		public const string net_log_cache_ftp_method = "net_log_cache_ftp_method";

		public const string net_log_cache_existing_not_removed_because_unexpected_response_status = "net_log_cache_existing_not_removed_because_unexpected_response_status";

		public const string net_log_cache_expected_length = "net_log_cache_expected_length";

		public const string net_log_cache_expires = "net_log_cache_expires";

		public const string net_log_cache_failing_request_with_exception = "net_log_cache_failing_request_with_exception";

		public const string net_log_cache_filename = "net_log_cache_filename";

		public const string net_log_cache_freshness_outside_policy_limits = "net_log_cache_freshness_outside_policy_limits";

		public const string net_log_cache_http_header_parse_error = "net_log_cache_http_header_parse_error";

		public const string net_log_cache_last_modified = "net_log_cache_last_modified";

		public const string net_log_cache_last_modified_header_older_than_cache_entry = "net_log_cache_last_modified_header_older_than_cache_entry";

		public const string net_log_cache_last_synchronized = "net_log_cache_last_synchronized";

		public const string net_log_cache_lookup_failed = "net_log_cache_lookup_failed";

		public const string net_log_cache_max_age_absolute = "net_log_cache_max_age_absolute";

		public const string net_log_cache_max_age_cache_max_age = "net_log_cache_max_age_cache_max_age";

		public const string net_log_cache_key_status = "net_log_cache_key_status";

		public const string net_log_cache_http_resp_is_null = "net_log_cache_http_resp_is_null";

		public const string net_log_cache_http_status_line = "net_log_cache_http_status_line";

		public const string net_log_cache_http_status_parse_failure = "net_log_cache_http_status_parse_failure";

		public const string net_log_cache_invalid_http_version = "net_log_cache_invalid_http_version";

		public const string net_log_cache_key = "net_log_cache_key";

		public const string net_log_cache_key_remove_failed_status = "net_log_cache_key_remove_failed_status";

		public const string net_log_cache_existing_entry_should_be_discarded = "net_log_cache_existing_entry_should_be_discarded";

		public const string net_log_cache_content_range_error = "net_log_cache_content_range_error";

		public const string net_log_cache_control_must_revalidate = "net_log_cache_control_must_revalidate";

		public const string net_log_cache_control_no_cache = "net_log_cache_control_no_cache";

		public const string net_log_cache_control_no_cache_removing_some_headers = "net_log_cache_control_no_cache_removing_some_headers";

		public const string net_log_cache_could_be_partial = "net_log_cache_could_be_partial";

		public const string net_log_cache_create_failed = "net_log_cache_create_failed";

		public const string net_log_cache_conditional_range_not_implemented_on_http_10 = "net_log_cache_conditional_range_not_implemented_on_http_10";

		public const string net_log_cache_closing_cache_stream = "net_log_cache_closing_cache_stream";

		public const string net_log_cache_combined_resp_requested = "net_log_cache_combined_resp_requested";

		public const string net_log_cache_commit_failed = "net_log_cache_commit_failed";

		public const string net_log_cache_condition_if_modified_since = "net_log_cache_condition_if_modified_since";

		public const string net_log_cache_condition_if_none_match = "net_log_cache_condition_if_none_match";

		public const string net_log_cache_condition_if_range = "net_log_cache_condition_if_range";

		public const string net_log_cache_date_header_older_than_cache_entry = "net_log_cache_date_header_older_than_cache_entry";

		public const string net_log_cache_entry_not_found_freshness_undefined = "net_log_cache_entry_not_found_freshness_undefined";

		public const string net_log_cache_entry_size_too_big = "net_log_cache_entry_size_too_big";

		public const string net_log_cache_error_deleting_filename = "net_log_cache_error_deleting_filename";

		public const string net_log_cache_exception = "net_log_cache_exception";

		public const string net_log_cache_exception_ignored = "net_log_cache_exception_ignored";

		public const string net_log_cache_existing_entry_has_to_be_discarded = "net_log_cache_existing_entry_has_to_be_discarded";

		public const string net_log_cache_enable_max_stale = "net_log_cache_enable_max_stale";

		public const string net_log_cache_delete_failed = "net_log_cache_delete_failed";

		public const string net_log_cache_disable_max_stale = "net_log_cache_disable_max_stale";

		public const string net_log_cache_dont_update_cached_headers = "net_log_cache_dont_update_cached_headers";

		public const string net_log_cache_dumping = "net_log_cache_dumping";

		public const string net_log_cache_dumping_cache_context = "net_log_cache_dumping_cache_context";

		public const string net_log_cache_dumping_metadata = "net_log_cache_dumping_metadata";

		public const string net_log_listener_httpsys_registry_error = "net_log_listener_httpsys_registry_error";

		public const string net_sockets_no_duplicate_async = "net_sockets_no_duplicate_async";

		public const string net_sockets_namedmustnotbebound = "net_sockets_namedmustnotbebound";

		public const string net_sockets_mustnotlisten = "net_sockets_mustnotlisten";

		public const string net_sockets_mustnotbebound = "net_sockets_mustnotbebound";

		public const string net_sockets_mustlisten = "net_sockets_mustlisten";

		public const string net_sockets_mustbind = "net_sockets_mustbind";

		public const string net_sockets_empty_select = "net_sockets_empty_select";

		public const string net_sockets_invalid_dnsendpoint = "net_sockets_invalid_dnsendpoint";

		public const string net_sockets_invalid_ipaddress_length = "net_sockets_invalid_ipaddress_length";

		public const string net_sockets_invalid_optionValue = "net_sockets_invalid_optionValue";

		public const string net_sockets_invalid_optionValue_all = "net_sockets_invalid_optionValue_all";

		public const string net_sockets_invalid_socketinformation = "net_sockets_invalid_socketinformation";

		public const string net_sockets_select = "net_sockets_select";

		public const string net_stopped = "net_stopped";

		public const string net_tcplistener_mustbestopped = "net_tcplistener_mustbestopped";

		public const string net_timeout = "net_timeout";

		public const string net_tooManyRedirections = "net_tooManyRedirections";

		public const string net_toolong = "net_toolong";

		public const string net_toosmall = "net_toosmall";

		public const string net_ssp_dont_support_cbt = "net_ssp_dont_support_cbt";

		public const string net_sockets_toolarge_select = "net_sockets_toolarge_select";

		public const string net_sockets_useblocking = "net_sockets_useblocking";

		public const string net_sockets_zerolist = "net_sockets_zerolist";

		public const string net_ssl_io_cert_validation = "net_ssl_io_cert_validation";

		public const string net_ssl_io_frame = "net_ssl_io_frame";

		public const string net_ssl_io_no_server_cert = "net_ssl_io_no_server_cert";

		public const string net_sockets_disconnectedConnect = "net_sockets_disconnectedConnect";

		public const string net_proxy_invalid_dayofweek = "net_proxy_invalid_dayofweek";

		public const string net_proxy_invalid_url_format = "net_proxy_invalid_url_format";

		public const string net_proxy_not_gmt = "net_proxy_not_gmt";

		public const string net_proxyschemenotsupported = "net_proxyschemenotsupported";

		public const string net_rangetoosmall = "net_rangetoosmall";

		public const string net_rangetype = "net_rangetype";

		public const string net_protocol_invalid_multicast_family = "net_protocol_invalid_multicast_family";

		public const string net_perm_epname = "net_perm_epname";

		public const string net_perm_invalid_val = "net_perm_invalid_val";

		public const string net_perm_invalid_val_in_element = "net_perm_invalid_val_in_element";

		public const string net_perm_target = "net_perm_target";

		public const string net_ping = "net_ping";

		public const string net_protocol_invalid_family = "net_protocol_invalid_family";

		public const string net_readonlystream = "net_readonlystream";

		public const string net_securityprotocolnotsupported = "net_securityprotocolnotsupported";

		public const string net_servererror = "net_servererror";

		public const string net_servicePointAddressNotSupportedInHostMode = "net_servicePointAddressNotSupportedInHostMode";

		public const string net_socketopinprogress = "net_socketopinprogress";

		public const string net_sockets_blocking = "net_sockets_blocking";

		public const string net_sockets_disconnectedAccept = "net_sockets_disconnectedAccept";

		public const string net_securitypackagesupport = "net_securitypackagesupport";

		public const string net_redirect_perm = "net_redirect_perm";

		public const string net_repcall = "net_repcall";

		public const string net_reqsubmitted = "net_reqsubmitted";

		public const string net_resubmitcanceled = "net_resubmitcanceled";

		public const string net_resubmitprotofailed = "net_resubmitprotofailed";

		public const string net_rspsubmitted = "net_rspsubmitted";

		public const string net_udpconnected = "net_udpconnected";

		public const string TL_InitializeData_NotSpecified = "initializeData needs to be valid for this TraceListener.";

		public const string Could_not_create_type_instance = "Could not create {0}.";

		public const string Could_not_find_type = "Couldn't find type for class {0}.";

		public const string Could_not_get_constructor = "Couldn't find constructor for class {0}.";

		public const string EmptyTypeName_NotAllowed = "switchType needs to be a valid class name. It can't be empty.";

		public const string Incorrect_base_type = "The specified type, '{0}' is not derived from the appropriate base type, '{1}'.";

		public const string Could_not_create_listener = "Couldn't create listener '{0}'.";

		public const string TraceAsTraceSource = "Trace";

		public const string MustAddListener = "Only TraceListeners can be added to a TraceListenerCollection.";

		public const string DebugAssertShortMessage = "---- Assert Short Message ----";

		public const string DebugAssertLongMessage = "---- Assert Long Message ----";

		public const string BadConfigSwitchValue = "The config value for Switch '{0}' was invalid.";

		public const string AttributeNotSupported = "'{0}' is not a valid configuration attribute for type '{1}'.";

		public const string Only_specify_one = "'switchValue' and 'switchName' cannot both be specified on source '{0}'.";

		public const string InvalidPrimitiveType = "Invalid Primitive Type: {0}. Consider using CodeObjectCreateExpression.";

		public const string ArityDoesntMatch = "The total arity specified in '{0}' does not match the number of TypeArguments supplied.  There were '{1}' TypeArguments supplied.";

		public const string InvalidPathCharsInChecksum = "The CodeChecksumPragma file name '{0}' contains invalid path characters.";

		public const string InvalidLanguageIdentifier = "The identifier:\"{0}\" on the property:\"{1}\" of type:\"{2}\" is not a valid language-independent identifier name. Check to see if CodeGenerator.IsValidLanguageIndependentIdentifier allows the identifier name.";

		public const string InvalidTypeName = "The type name:\"{0}\" on the property:\"{1}\" of type:\"{2}\" is not a valid language-independent type name.";

		public const string InvalidRegion = "The region directive '{0}' contains invalid characters.  RegionText cannot contain any new line characters.";

		public const string InvalidIdentifier = "Identifier '{0}' is not valid.";

		public const string Reference_listener_cant_have_properties = "A listener with no type name specified references the sharedListeners section and cannot have any attributes other than 'Name'.  Listener: '{0}'.";

		public const string Reference_to_nonexistent_listener = "Listener '{0}' does not exist in the sharedListeners section.";

		public const string Argument_NullComment = "The 'Comment' property of the CodeCommentStatement '{0}' cannot be null.";

		public const string CodeGenOutputWriter = "The output writer for code generation and the writer supplied don't match and cannot be used. This is generally caused by a bad implementation of a CodeGenerator derived class.";

		public const string CodeGenReentrance = "This code generation API cannot be called while the generator is being used to generate something else.";

		public const string InvalidElementType = "Element type {0} is not supported.";

		public const string TraceListenerFail = "Fail:";

		public const string net_webclient_invalid_baseaddress = "net_webclient_invalid_baseaddress";

		public const string net_webclient_no_concurrent_io_allowed = "net_webclient_no_concurrent_io_allowed";

		public const string net_webstatus_ConnectFailure = "net_webstatus_ConnectFailure";

		public const string net_webstatus_MessageLengthLimitExceeded = "net_webstatus_MessageLengthLimitExceeded";

		public const string net_webstatus_RequestCanceled = "net_webstatus_RequestCanceled";

		public const string net_webstatus_ServerProtocolViolation = "net_webstatus_ServerProtocolViolation";

		public const string net_webclient_Multipart = "net_webclient_Multipart";

		public const string net_unknown_osinstalltype = "net_unknown_osinstalltype";

		public const string net_unknown_prefix = "net_unknown_prefix";

		public const string net_uri_NotAbsolute = "net_uri_NotAbsolute";

		public const string net_value_cannot_be_negative = "net_value_cannot_be_negative";

		public const string net_webclient = "net_webclient";

		public const string net_webclient_ContentType = "net_webclient_ContentType";

		public const string net_writeonlystream = "net_writeonlystream";

		public const string DebugAssertBanner = "---- DEBUG ASSERTION FAILED ----";

		public const string ExceptionOccurred = "An exception occurred writing trace output to log file '{0}'. {1}";

		public const string TraceSwitchLevelTooHigh = "Attempted to set {0} to a value that is too high.  Setting level to TraceLevel.Verbose";

		public const string TraceSwitchLevelTooLow = "Attempted to set {0} to a value that is too low.  Setting level to TraceLevel.Off";

		public const string TraceSwitchInvalidLevel = "The Level must be set to a value in the enumeration TraceLevel.";

		public const string TraceListenerIndentSize = "The IndentSize property must be non-negative.";

		public const string Argument_FrameworkNameTooShort = "Argument_FrameworkNameTooShort";

		public const string net_writestarted = "net_writestarted";

		public const string net_wrongversion = "net_wrongversion";

		public const string security_ExtendedProtection_NoOSSupport = "security_ExtendedProtection_NoOSSupport";

		public const string Argument_FrameworkNameInvalid = "Argument_FrameworkNameInvalid";

		public const string Argument_FrameworkNameInvalidVersion = "Argument_FrameworkNameInvalidVersion";

		public const string Argument_FrameworkNameMissingVersion = "Argument_FrameworkNameMissingVersion";

		public const string net_perm_both_regex = "net_perm_both_regex";

		public const string net_log_proxy_called_with_null_parameter = "net_log_proxy_called_with_null_parameter";

		public const string net_log_proxy_ras_notsupported_exception = "net_log_proxy_ras_notsupported_exception";

		public const string net_log_proxy_ras_supported = "net_log_proxy_ras_supported";

		public const string net_log_proxy_script_download_compile_error = "net_log_proxy_script_download_compile_error";

		public const string net_log_proxy_script_execution_error = "net_log_proxy_script_execution_error";

		public const string net_log_proxy_system_setting_update = "net_log_proxy_system_setting_update";

		public const string net_log_proxy_called_with_invalid_parameter = "net_log_proxy_called_with_invalid_parameter";

		public const string net_log_no_issuers_try_all_certs = "net_log_no_issuers_try_all_certs";

		public const string net_log_open_store_failed = "net_log_open_store_failed";

		public const string net_log_operation_failed_with_error = "net_log_operation_failed_with_error";

		public const string net_log_operation_returned_something = "net_log_operation_returned_something";

		public const string net_log_proxy_autodetect_failed = "net_log_proxy_autodetect_failed";

		public const string net_log_proxy_autodetect_script_location_parse_error = "net_log_proxy_autodetect_script_location_parse_error";

		public const string net_log_proxy_update_due_to_ip_config_change = "net_log_proxy_update_due_to_ip_config_change";

		public const string net_log_remote_cert_has_errors = "net_log_remote_cert_has_errors";

		public const string net_log_remote_cert_has_no_errors = "net_log_remote_cert_has_no_errors";

		public const string net_log_remote_cert_name_mismatch = "net_log_remote_cert_name_mismatch";

		public const string net_log_remote_cert_not_available = "net_log_remote_cert_not_available";

		public const string net_log_remote_cert_user_declared_invalid = "net_log_remote_cert_user_declared_invalid";

		public const string net_log_remote_cert_user_declared_valid = "net_log_remote_cert_user_declared_valid";

		public const string net_log_releasing_connection = "net_log_releasing_connection";

		public const string net_log_proxy_winhttp_cant_open_session = "net_log_proxy_winhttp_cant_open_session";

		public const string net_log_proxy_winhttp_getproxy_failed = "net_log_proxy_winhttp_getproxy_failed";

		public const string net_log_proxy_winhttp_timeout_error = "net_log_proxy_winhttp_timeout_error";

		public const string net_log_received_headers = "net_log_received_headers";

		public const string net_log_received_response = "net_log_received_response";

		public const string net_log_received_status_line = "net_log_received_status_line";

		public const string net_log_no_delegate_but_have_client_cert = "net_log_no_delegate_but_have_client_cert";

		public const string net_log_listener_no_spn_kerberos = "net_log_listener_no_spn_kerberos";

		public const string net_log_listener_no_spn_loopback = "net_log_listener_no_spn_loopback";

		public const string net_log_listener_no_spn_platform = "net_log_listener_no_spn_platform";

		public const string net_log_listener_no_spn_whensupported = "net_log_listener_no_spn_whensupported";

		public const string net_log_listener_spn = "net_log_listener_spn";

		public const string net_log_listener_spn_add = "net_log_listener_spn_add";

		public const string net_log_listener_no_spn_disabled = "net_log_listener_no_spn_disabled";

		public const string net_log_listener_httpsys_registry_null = "net_log_listener_httpsys_registry_null";

		public const string net_log_listener_no_cbt_disabled = "net_log_listener_no_cbt_disabled";

		public const string net_log_listener_no_cbt_http = "net_log_listener_no_cbt_http";

		public const string net_log_listener_no_cbt_platform = "net_log_listener_no_cbt_platform";

		public const string net_log_listener_no_cbt_trustedproxy = "net_log_listener_no_cbt_trustedproxy";

		public const string net_log_listener_no_spn_cbt = "net_log_listener_no_spn_cbt";

		public const string net_log_listener_spn_failed = "net_log_listener_spn_failed";

		public const string net_log_listener_unmatched_authentication_scheme = "net_log_listener_unmatched_authentication_scheme";

		public const string net_log_listener_unsupported_authentication_scheme = "net_log_listener_unsupported_authentication_scheme";

		public const string net_log_locating_private_key_for_certificate = "net_log_locating_private_key_for_certificate";

		public const string net_log_method_equal = "net_log_method_equal";

		public const string net_log_n_certs_after_filtering = "net_log_n_certs_after_filtering";

		public const string net_log_no_delegate_and_have_no_client_cert = "net_log_no_delegate_and_have_no_client_cert";

		public const string net_log_listener_spn_remove = "net_log_listener_spn_remove";

		public const string net_log_listener_spn_failed_always = "net_log_listener_spn_failed_always";

		public const string net_log_listener_spn_failed_dump = "net_log_listener_spn_failed_dump";

		public const string net_log_listener_spn_failed_empty = "net_log_listener_spn_failed_empty";

		public const string net_log_listener_spn_not_add = "net_log_listener_spn_not_add";

		public const string net_log_listener_spn_not_remove = "net_log_listener_spn_not_remove";

		public const string net_log_listener_spn_passed = "net_log_listener_spn_passed";

		public const string net_log_remote_certificate = "net_log_remote_certificate";

		public const string net_nochunkuploadonhttp10 = "net_nochunkuploadonhttp10";

		public const string net_nocontentlengthonget = "net_nocontentlengthonget";

		public const string net_nodefaultcreds = "net_nodefaultcreds";

		public const string net_nonClsCompliantException = "net_nonClsCompliantException";

		public const string net_noseek = "net_noseek";

		public const string net_not_ipermission = "net_not_ipermission";

		public const string net_nochunked = "net_nochunked";

		public const string net_needchunked = "net_needchunked";

		public const string net_needmorethreads = "net_needmorethreads";

		public const string net_no100 = "net_no100";

		public const string net_no_classname = "net_no_classname";

		public const string net_no_concurrent_io_allowed = "net_no_concurrent_io_allowed";

		public const string net_no_typename = "net_no_typename";

		public const string net_notconnected = "net_notconnected";

		public const string net_perfcounter_initialization_started = "net_perfcounter_initialization_started";

		public const string net_perfcounter_initialized_error = "net_perfcounter_initialized_error";

		public const string net_perfcounter_initialized_success = "net_perfcounter_initialized_success";

		public const string net_perfcounter_nocategory = "net_perfcounter_nocategory";

		public const string net_perm_attrib_count = "net_perm_attrib_count";

		public const string net_perm_attrib_multi = "net_perm_attrib_multi";

		public const string net_perfcounter_cant_queue_workitem = "net_perfcounter_cant_queue_workitem";

		public const string net_notstream = "net_notstream";

		public const string net_nottoken = "net_nottoken";

		public const string net_nouploadonget = "net_nouploadonget";

		public const string net_offset_plus_count = "net_offset_plus_count";

		public const string net_osinstalltype = "net_osinstalltype";

		public const string net_param_not_string = "net_param_not_string";

		public const string net_need_writebuffering = "net_need_writebuffering";

		public const string net_log_server_response_error_code = "net_log_server_response_error_code";

		public const string net_log_shell_expression_pattern_format_warning = "net_log_shell_expression_pattern_format_warning";

		public const string net_log_socket_accepted = "net_log_socket_accepted";

		public const string net_log_socket_connect_dnsendpoint = "net_log_socket_connect_dnsendpoint";

		public const string net_log_socket_connected = "net_log_socket_connected";

		public const string net_log_socket_not_logged_file = "net_log_socket_not_logged_file";

		public const string net_log_server_issuers_look_for_matching_certs = "net_log_server_issuers_look_for_matching_certs";

		public const string net_log_resolved_servicepoint_may_not_be_remote_server = "net_log_resolved_servicepoint_may_not_be_remote_server";

		public const string net_log_resubmitting_request = "net_log_resubmitting_request";

		public const string net_log_retrieving_localhost_exception = "net_log_retrieving_localhost_exception";

		public const string net_log_selected_cert = "net_log_selected_cert";

		public const string net_log_sending_command = "net_log_sending_command";

		public const string net_log_sending_headers = "net_log_sending_headers";

		public const string net_log_sspi_enumerating_security_packages = "net_log_sspi_enumerating_security_packages";

		public const string net_max_ip_address_list_length_exceeded = "net_max_ip_address_list_length_exceeded";

		public const string net_maxsrvpoints = "net_maxsrvpoints";

		public const string net_multibuffernotsupported = "net_multibuffernotsupported";

		public const string net_must_provide_request_body = "net_must_provide_request_body";

		public const string net_mustbeuri = "net_mustbeuri";

		public const string net_mutualauthfailed = "net_mutualauthfailed";

		public const string net_log_using_cached_credential = "net_log_using_cached_credential";

		public const string net_log_sspi_security_context_input_buffer = "net_log_sspi_security_context_input_buffer";

		public const string net_log_sspi_security_context_input_buffers = "net_log_sspi_security_context_input_buffers";

		public const string net_log_sspi_security_package_not_found = "net_log_sspi_security_package_not_found";

		public const string net_log_sspi_selected_cipher_suite = "net_log_sspi_selected_cipher_suite";

		public const string net_log_unexpected_exception = "net_log_unexpected_exception";

		public const string net_log_unknown = "net_log_unknown";

		public const string net_io_eof = "net_io_eof";

		public const string ErrorInvalidServiceInstance = "ErrorInvalidServiceInstance";

		public const string ErrorInvalidPropertyType = "ErrorInvalidPropertyType";

		public const string ErrorInvalidEventType = "ErrorInvalidEventType";

		public const string ErrorInvalidEventHandler = "ErrorInvalidEventHandler";

		public const string ErrorBadExtenderType = "ErrorBadExtenderType";

		public const string EnumConverterInvalidValue = "The value '{0}' is not a valid value for the enum '{1}'.";

		public const string ConvertFromException = "{0} cannot convert from {1}.";

		public const string ConvertInvalidPrimitive = "{0} is not a valid value for {1}.";

		public const string ConvertToException = "'{0}' is unable to convert '{1}' to '{2}'.";

		public const string CultureInfoConverterDefaultCultureString = "(Default)";

		public const string CultureInfoConverterInvalidCulture = "The {0} culture cannot be converted to a CultureInfo object on this computer.";

		public const string DuplicateComponentName = "Duplicate component name '{0}'.  Component names must be unique and case-insensitive.";

		public const string ErrorMissingEventAccessors = "ErrorMissingEventAccessors";

		public const string InstanceDescriptorMustBeReadable = "InstanceDescriptorMustBeReadable";

		public const string InstanceDescriptorMustBeStatic = "InstanceDescriptorMustBeStatic";

		public const string InvalidArgument = "InvalidArgument";

		public const string InvalidEnumArgument = "The value of argument '{0}' ({1}) is invalid for Enum type '{2}'.";

		public const string InvalidMemberName = "InvalidMemberName";

		public const string InvalidNullArgument = "InvalidNullArgument";

		public const string InstanceDescriptorLengthMismatch = "InstanceDescriptorLengthMismatch";

		public const string ErrorMissingPropertyAccessors = "ErrorMissingPropertyAccessors";

		public const string ErrorPropertyAccessorException = "ErrorPropertyAccessorException";

		public const string ErrorServiceExists = "The service {0} already exists in the service container.";

		public const string ISupportInitializeDescr = "ISupportInitializeDescr";

		public const string InstanceCreationEditorDefaultText = "InstanceCreationEditorDefaultText";

		public const string InstanceDescriptorCannotBeStatic = "InstanceDescriptorCannotBeStatic";

		public const string CollectionConverterText = "(Collection)";

		public const string Async_NullDelegate = "Async_NullDelegate";

		public const string Async_OperationAlreadyCompleted = "Async_OperationAlreadyCompleted";

		public const string Async_OperationCancelled = "Async_OperationCancelled";

		public const string Async_ProgressChangedEventArgs_ProgressPercentage = "Async_ProgressChangedEventArgs_ProgressPercentage";

		public const string Async_ProgressChangedEventArgs_UserState = "Async_ProgressChangedEventArgs_UserState";

		public const string BackgroundWorker_CancellationPending = "BackgroundWorker_CancellationPending";

		public const string Async_ExceptionOccurred = "Async_ExceptionOccurred";

		public const string WrongActionForCtor = "WrongActionForCtor";

		public const string ObservableCollectionReentrancyNotAllowed = "ObservableCollectionReentrancyNotAllowed";

		public const string ArrayConverterText = "{0} Array";

		public const string Async_AsyncEventArgs_Cancelled = "Async_AsyncEventArgs_Cancelled";

		public const string Async_AsyncEventArgs_Error = "Async_AsyncEventArgs_Error";

		public const string Async_AsyncEventArgs_UserState = "Async_AsyncEventArgs_UserState";

		public const string BackgroundWorker_Desc = "BackgroundWorker_Desc";

		public const string BackgroundWorker_WorkerDoesntReportProgress = "BackgroundWorker_WorkerDoesntReportProgress";

		public const string BackgroundWorker_WorkerDoesntSupportCancellation = "BackgroundWorker_WorkerDoesntSupportCancellation";

		public const string BackgroundWorker_WorkerReportsProgress = "BackgroundWorker_WorkerReportsProgress";

		public const string BackgroundWorker_WorkerSupportsCancellation = "BackgroundWorker_WorkerSupportsCancellation";

		public const string CHECKOUTCanceled = "CHECKOUTCanceled";

		public const string CantModifyListSortDescriptionCollection = "CantModifyListSortDescriptionCollection";

		public const string BackgroundWorker_WorkerAlreadyRunning = "BackgroundWorker_WorkerAlreadyRunning";

		public const string BackgroundWorker_DoWork = "BackgroundWorker_DoWork";

		public const string BackgroundWorker_DoWorkEventArgs_Argument = "BackgroundWorker_DoWorkEventArgs_Argument";

		public const string BackgroundWorker_DoWorkEventArgs_Result = "BackgroundWorker_DoWorkEventArgs_Result";

		public const string BackgroundWorker_IsBusy = "BackgroundWorker_IsBusy";

		public const string BackgroundWorker_ProgressChanged = "BackgroundWorker_ProgressChanged";

		public const string BackgroundWorker_RunWorkerCompleted = "BackgroundWorker_RunWorkerCompleted";

		public const string LicExceptionTypeAndInstance = "LicExceptionTypeAndInstance";

		public const string Barrier_AddParticipants_Overflow_ArgumentOutOfRange = "Barrier_AddParticipants_Overflow_ArgumentOutOfRange";

		public const string Barrier_Dispose = "Barrier_Dispose";

		public const string Barrier_InvalidOperation_CalledFromPHA = "Barrier_InvalidOperation_CalledFromPHA";

		public const string Barrier_RemoveParticipants_ArgumentOutOfRange = "Barrier_RemoveParticipants_ArgumentOutOfRange";

		public const string Barrier_RemoveParticipants_InvalidOperation = "Barrier_RemoveParticipants_InvalidOperation";

		public const string Barrier_RemoveParticipants_NonPositive_ArgumentOutOfRange = "Barrier_RemoveParticipants_NonPositive_ArgumentOutOfRange";

		public const string Barrier_AddParticipants_NonPositive_ArgumentOutOfRange = "Barrier_AddParticipants_NonPositive_ArgumentOutOfRange";

		public const string Argument_InvalidPermissionState = "Argument_InvalidPermissionState";

		public const string Argument_WrongType = "Argument_WrongType";

		public const string ArgumentOutOfRange_NeedPosNum = "ArgumentOutOfRange_NeedPosNum";

		public const string Argument_SemaphoreInitialMaximum = "Argument_SemaphoreInitialMaximum";

		public const string Argument_WaitHandleNameTooLong = "Argument_WaitHandleNameTooLong";

		public const string BarrierPostPhaseException = "BarrierPostPhaseException";

		public const string Barrier_SignalAndWait_ArgumentOutOfRange = "Barrier_SignalAndWait_ArgumentOutOfRange";

		public const string TimerInterval = "TimerInterval";

		public const string TimerIntervalElapsed = "TimerIntervalElapsed";

		public const string TimerInvalidInterval = "TimerInvalidInterval";

		public const string TimerSynchronizingObject = "TimerSynchronizingObject";

		public const string ArgumentOutOfRange_Bounds_Lower_Upper = "ArgumentOutOfRange_Bounds_Lower_Upper";

		public const string ContentDispositionInvalid = "ContentDispositionInvalid";

		public const string TimerEnabled = "TimerEnabled";

		public const string Barrier_SignalAndWait_InvalidOperation_ThreadsExceeded = "Barrier_SignalAndWait_InvalidOperation_ThreadsExceeded";

		public const string Barrier_SignalAndWait_InvalidOperation_ZeroTotal = "Barrier_SignalAndWait_InvalidOperation_ZeroTotal";

		public const string Barrier_ctor_ArgumentOutOfRange = "Barrier_ctor_ArgumentOutOfRange";

		public const string WaitHandleCannotBeOpenedException_InvalidHandle = "WaitHandleCannotBeOpenedException_InvalidHandle";

		public const string InvalidParameter = "InvalidParameter";

		public const string TimerAutoReset = "TimerAutoReset";

		public const string Argument_InvalidClassAttribute = "Argument_InvalidClassAttribute";

		public const string MaskedTextProviderPasswordAndPromptCharError = "MaskedTextProviderPasswordAndPromptCharError";

		public const string MemberRelationshipService_RelationshipNotSupported = "MemberRelationshipService_RelationshipNotSupported";

		public const string MetaExtenderName = "MetaExtenderName";

		public const string MultilineStringConverterText = "(Text)";

		public const string NullableConverterBadCtorArg = "NullableConverterBadCtorArg";

		public const string PropertyCategoryAsynchronous = "PropertyCategoryAsynchronous";

		public const string MaskedTextProviderMaskNullOrEmpty = "MaskedTextProviderMaskNullOrEmpty";

		public const string LicExceptionTypeOnly = "LicExceptionTypeOnly";

		public const string LicMgrAlreadyLocked = "LicMgrAlreadyLocked";

		public const string LicMgrContextCannotBeChanged = "LicMgrContextCannotBeChanged";

		public const string LicMgrDifferentUser = "LicMgrDifferentUser";

		public const string MaskedTextProviderInvalidCharError = "MaskedTextProviderInvalidCharError";

		public const string MaskedTextProviderMaskInvalidChar = "MaskedTextProviderMaskInvalidChar ";

		public const string PropertyTabAttributeArrayLengthMismatch = "PropertyTabAttributeArrayLengthMismatch";

		public const string TypeDescriptorExpectedElementType = "TypeDescriptorExpectedElementType";

		public const string TypeDescriptorProviderError = "TypeDescriptorProviderError";

		public const string TypeDescriptorSameAssociation = "TypeDescriptorSameAssociation";

		public const string TypeDescriptorUnsupportedRemoteObject = "TypeDescriptorUnsupportedRemoteObject";

		public const string toStringNone = "(none)";

		public const string Arg_EnumIllegalVal = "Arg_EnumIllegalVal";

		public const string TypeDescriptorArgsCountMismatch = "TypeDescriptorArgsCountMismatch";

		public const string PropertyTabAttributeBadPropertyTabScope = "PropertyTabAttributeBadPropertyTabScope";

		public const string PropertyTabAttributeParamsBothNull = "PropertyTabAttributeParamsBothNull";

		public const string PropertyTabAttributeTypeLoadException = "PropertyTabAttributeTypeLoadException";

		public const string ToStringNull = "(null)";

		public const string ToolboxItemAttributeFailedGetType = "ToolboxItemAttributeFailedGetType";

		public const string TypeDescriptorAlreadyAssociated = "TypeDescriptorAlreadyAssociated";

		public const string ResetActionRequiresNullItem = "ResetActionRequiresNullItem";

		public const string UndefinedReference = "(?({0}) ) reference to undefined group.";

		public const string UnexpectedOpcode = "Unexpected opcode in regular expression generation: {0}.";

		public const string UnimplementedState = "Unimplemented state.";

		public const string UnknownProperty = "Unknown property '{0}'.";

		public const string UnrecognizedControl = "Unrecognized control character.";

		public const string UnrecognizedEscape = "Unrecognized escape sequence {0}.";

		public const string UndefinedNameRef = "Reference to undefined group name {0}.";

		public const string ReversedCharRange = "[x-y] range in reverse order.";

		public const string SubtractionMustBeLast = "A subtraction must be the last element in a character class.";

		public const string TooFewHex = "Insufficient hexadecimal digits.";

		public const string TooManyAlternates = "Too many | in (?()|).";

		public const string TooManyParens = "Too many )'s.";

		public const string UndefinedBackref = "Reference to undefined group number {0}.";

		public const string UnrecognizedGrouping = "Unrecognized grouping construct.";

		public const string Arg_WrongType = "Arg_WrongType";

		public const string ArgumentOutOfRange_Index = "ArgumentOutOfRange_Index";

		public const string ArgumentOutOfRange_NeedNonNegNum = "ArgumentOutOfRange_NeedNonNegNum";

		public const string ArgumentOutOfRange_NeedNonNegNumRequired = "ArgumentOutOfRange_NeedNonNegNumRequired";

		public const string ArgumentOutOfRange_SmallCapacity = "ArgumentOutOfRange_SmallCapacity";

		public const string Argument_AddingDuplicate = "Argument_AddingDuplicate";

		public const string Arg_NonZeroLowerBound = "Arg_NonZeroLowerBound";

		public const string UnterminatedBracket = "Unterminated [] set.";

		public const string UnterminatedComment = "Unterminated (?#...) comment.";

		public const string ArgumentNull_ArrayWithNullElements = "ArgumentNull_ArrayWithNullElements";

		public const string Arg_ArrayPlusOffTooSmall = "Arg_ArrayPlusOffTooSmall";

		public const string Arg_InsufficientSpace = "Arg_InsufficientSpace";

		public const string Arg_MultiRank = "Arg_MultiRank";

		public const string ReplacementError = "Replacement pattern error.";

		public const string CountTooSmall = "Count cannot be less than -1.";

		public const string EnumNotStarted = "Enumeration has either not started or has already finished.";

		public const string IllegalCondition = "Illegal conditional (?(...)) expression.";

		public const string IllegalEndEscape = "Illegal \\ at end of pattern.";

		public const string IllegalRange = "Illegal {x,y} with x > y.";

		public const string IncompleteSlashP = "Incomplete \\{X} character escape.";

		public const string CaptureGroupOutOfRange = "Capture group numbers must be less than or equal to Int32.MaxValue.";

		public const string AlternationCantHaveComment = "Alternation conditions cannot be comments.";

		public const string Arg_InvalidArrayType = "Target array type is not compatible with the type of items in the collection.";

		public const string Arg_RankMultiDimNotSupported = "Only single dimensional arrays are supported for the requested action.";

		public const string BadClassInCharRange = "Cannot include class {0} in character range.";

		public const string BeginIndexNotNegative = "Start index cannot be less than 0 or greater than input length.";

		public const string CapnumNotZero = "Capture number cannot be zero.";

		public const string InternalError = "Internal error in ScanRegex.";

		public const string NestedQuantify = "Nested quantifier {0}.";

		public const string NoResultOnFailed = "Result cannot be called on a failed Match.";

		public const string NotEnoughParens = "Not enough )'s.";

		public const string OnlyAllowedOnce = "This operation is only allowed once per object.";

		public const string QuantifyAfterNothing = "Quantifier {x,y} following nothing.";

		public const string RegexMatchTimeoutException_Occurred = "The RegEx engine has timed out while trying to match a pattern to an input string. This can occur for many reasons, including very large inputs or excessive backtracking caused by nested quantifiers, back-references and other factors.";

		public const string MissingControl = "Missing control character.";

		public const string InvalidGroupName = "Invalid group name: Group names must begin with a word character.";

		public const string LengthNotNegative = "Length cannot be less than 0 or exceed input length.";

		public const string MakeException = "parsing '{0}' - {1}";

		public const string MalformedNameRef = "Malformed \\k<...> named back reference.";

		public const string MalformedReference = "(?({0}) ) malformed.";

		public const string MalformedSlashP = "Malformed \\p{X} character escape.";

		public const string Argument_ImplementIComparable = "Argument_ImplementIComparable";

		public const string BlockingCollection_ValidateCollectionsArray_LargeSize = "BlockingCollection_ValidateCollectionsArray_LargeSize";

		public const string BlockingCollection_ValidateCollectionsArray_NullElems = "BlockingCollection_ValidateCollectionsArray_NullElems";

		public const string BlockingCollection_ValidateCollectionsArray_ZeroSize = "BlockingCollection_ValidateCollectionsArray_ZeroSize";

		public const string BlockingCollection_ctor_BoundedCapacityRange = "BlockingCollection_ctor_BoundedCapacityRange";

		public const string BlockingCollection_ctor_CountMoreThanCapacity = "BlockingCollection_ctor_CountMoreThanCapacity";

		public const string Common_OperationCanceled = "Common_OperationCanceled";

		public const string BlockingCollection_ValidateCollectionsArray_DispElems = "BlockingCollection_ValidateCollectionsArray_DispElems";

		public const string BlockingCollection_CopyTo_MultiDim = "BlockingCollection_CopyTo_MultiDim";

		public const string BlockingCollection_CopyTo_NonNegative = "BlockingCollection_CopyTo_NonNegative";

		public const string BlockingCollection_CopyTo_TooManyElems = "BlockingCollection_CopyTo_TooManyElems";

		public const string BlockingCollection_Disposed = "BlockingCollection_Disposed";

		public const string BlockingCollection_Take_CollectionModified = "BlockingCollection_Take_CollectionModified";

		public const string BlockingCollection_TimeoutInvalid = "BlockingCollection_TimeoutInvalid";

		public const string ConcurrentBag_CopyTo_ArgumentNullException = "ConcurrentBag_CopyTo_ArgumentNullException";

		public const string IndexCannotBeNegative = "IndexCannotBeNegative";

		public const string IndexOutOfRange = "IndexOutOfRange";

		public const string MustBeResetAddOrRemoveActionForCtor = "MustBeResetAddOrRemoveActionForCtor";

		public const string OrderedDictionary_ReadOnly = "OrderedDictionary_ReadOnly";

		public const string OrderedDictionary_SerializationMismatch = "OrderedDictionary_SerializationMismatch";

		public const string ResetActionRequiresIndexMinus1 = "ResetActionRequiresIndexMinus1";

		public const string CollectionReadOnly = "CollectionReadOnly";

		public const string ConcurrentBag_CopyTo_ArgumentOutOfRangeException = "ConcurrentBag_CopyTo_ArgumentOutOfRangeException";

		public const string ConcurrentBag_Ctor_ArgumentNullException = "ConcurrentBag_Ctor_ArgumentNullException";

		public const string ConcurrentCollection_SyncRoot_NotSupported = "ConcurrentCollection_SyncRoot_NotSupported";

		public const string ArgumentNull_Key = "ArgumentNull_Key";

		public const string Argument_InvalidValue = "Argument_InvalidValue";

		public const string BitVectorFull = "BitVectorFull";

		public const string BlockingCollection_CopyTo_IncorrectType = "BlockingCollection_CopyTo_IncorrectType";

		public const string InvalidOperation_EnumFailedVersion = "InvalidOperation_EnumFailedVersion";

		public const string InvalidOperation_EnumNotStarted = "InvalidOperation_EnumNotStarted";

		public const string InvalidOperation_EnumOpCantHappen = "InvalidOperation_EnumOpCantHappen";

		public const string Invalid_Array_Type = "Invalid_Array_Type";

		public const string LinkedListEmpty = "LinkedListEmpty";

		public const string LinkedListNodeIsAttached = "LinkedListNodeIsAttached";

		public const string InvalidOperation_EnumEnded = "InvalidOperation_EnumEnded";

		public const string Argument_InvalidOffLen = "Argument_InvalidOffLen";

		public const string ExternalLinkedListNode = "ExternalLinkedListNode";

		public const string InvalidOperation_CannotRemoveFromStackOrQueue = "InvalidOperation_CannotRemoveFromStackOrQueue";

		public const string InvalidOperation_EmptyCollection = "InvalidOperation_EmptyCollection";

		public const string InvalidOperation_EmptyQueue = "InvalidOperation_EmptyQueue";

		public const string InvalidOperation_EmptyStack = "InvalidOperation_EmptyStack";

		public const string NotSupported_KeyCollectionSet = "NotSupported_KeyCollectionSet";

		public const string BlockingCollection_Add_ConcurrentCompleteAdd = "BlockingCollection_Add_ConcurrentCompleteAdd";

		public const string BlockingCollection_Add_Failed = "BlockingCollection_Add_Failed";

		public const string BlockingCollection_CantAddAnyWhenCompleted = "BlockingCollection_CantAddAnyWhenCompleted";

		public const string BlockingCollection_CantTakeAnyWhenAllDone = "BlockingCollection_CantTakeAnyWhenAllDone";

		public const string BlockingCollection_CantTakeWhenDone = "BlockingCollection_CantTakeWhenDone";

		public const string BlockingCollection_Completed = "BlockingCollection_Completed";

		public const string InvalidNullEmptyArgument = "InvalidNullEmptyArgument";

		public const string NotSupported_SortedListNestedWrite = "NotSupported_SortedListNestedWrite";

		public const string NotSupported_ValueCollectionSet = "NotSupported_ValueCollectionSet";

		public const string Serialization_InvalidOnDeser = "Serialization_InvalidOnDeser";

		public const string Serialization_MismatchedCount = "Serialization_MismatchedCount";

		public const string Serialization_MissingValues = "Serialization_MissingValues";

		public const string IllegalDefaultRegexMatchTimeoutInAppDomain = "IllegalDefaultRegexMatchTimeoutInAppDomain";

		public const string ContentTypeInvalid = "ContentTypeInvalid";

		public const string net_cache_non_seekable_stream_not_supported = "net_cache_non_seekable_stream_not_supported";

		public const string net_cache_not_accept_response = "net_cache_not_accept_response";

		public const string net_cache_not_supported_body = "net_cache_not_supported_body";

		public const string net_cache_not_supported_command = "net_cache_not_supported_command";

		public const string net_cache_retrieve_failure = "net_cache_retrieve_failure";

		public const string net_cache_shadowstream_not_writable = "net_cache_shadowstream_not_writable";

		public const string net_cache_no_stream = "net_cache_no_stream";

		public const string net_bad_ip_address_prefix = "net_bad_ip_address_prefix";

		public const string net_bad_mac_address = "net_bad_mac_address";

		public const string net_baddate = "net_baddate";

		public const string net_badmethod = "net_badmethod";

		public const string net_buffercounttoosmall = "net_buffercounttoosmall";

		public const string net_cache_access_denied = "net_cache_access_denied";

		public const string net_cache_unsupported_partial_stream = "net_cache_unsupported_partial_stream";

		public const string net_collection_readonly = "net_collection_readonly";

		public const string net_completed_result = "net_completed_result";

		public const string net_config_authenticationmodules = "net_config_authenticationmodules";

		public const string net_config_element_permission = "net_config_element_permission";

		public const string net_config_property_permission = "net_config_property_permission";

		public const string net_config_proxy = "net_config_proxy";

		public const string net_clsmall = "net_clsmall";

		public const string net_cache_validator_fail = "net_cache_validator_fail";

		public const string net_cache_validator_result = "net_cache_validator_result";

		public const string net_cannot_load_proxy_helper = "net_cannot_load_proxy_helper";

		public const string net_cant_create_environment = "net_cant_create_environment";

		public const string net_cant_determine_osinstalltype = "net_cant_determine_osinstalltype";

		public const string net_cant_perform_during_shutdown = "net_cant_perform_during_shutdown";

		public const string net_authschemenotregistered = "net_authschemenotregistered";

		public const string net_Websockets_AlreadyOneOutstandingOperation = "net_Websockets_AlreadyOneOutstandingOperation";

		public const string net_Websockets_WebSocketBaseFaulted = "net_Websockets_WebSocketBaseFaulted";

		public const string net_ambiguousbuffers = "net_ambiguousbuffers";

		public const string net_array_too_small = "net_array_too_small";

		public const string net_auth_SSPI = "net_auth_SSPI";

		public const string net_auth_alert = "net_auth_alert";

		public const string net_WebSockets_UnsupportedWebSocketVersion_Generic = "net_WebSockets_UnsupportedWebSocketVersion_Generic";

		public const string net_WebSockets_NotConnected = "net_WebSockets_NotConnected";

		public const string net_WebSockets_ReasonNotNull = "net_WebSockets_ReasonNotNull";

		public const string net_WebSockets_ReceiveAsyncDisallowedAfterCloseAsync = "net_WebSockets_ReceiveAsyncDisallowedAfterCloseAsync";

		public const string net_WebSockets_Scheme = "net_WebSockets_Scheme";

		public const string net_WebSockets_UnsupportedPlatform = "net_WebSockets_UnsupportedPlatform";

		public const string net_WebSockets_UnsupportedProtocol_Generic = "net_WebSockets_UnsupportedProtocol_Generic";

		public const string net_auth_bad_client_creds = "net_auth_bad_client_creds";

		public const string net_auth_must_specify_extended_protection_scheme = "net_auth_must_specify_extended_protection_scheme";

		public const string net_auth_no_anonymous_support = "net_auth_no_anonymous_support";

		public const string net_auth_noauth = "net_auth_noauth";

		public const string net_auth_reauth = "net_auth_reauth";

		public const string net_auth_supported_impl_levels = "net_auth_supported_impl_levels";

		public const string net_authmodulenotregistered = "net_authmodulenotregistered";

		public const string net_auth_message_not_encrypted = "net_auth_message_not_encrypted";

		public const string net_auth_bad_client_creds_or_target_mismatch = "net_auth_bad_client_creds_or_target_mismatch";

		public const string net_auth_client_server = "net_auth_client_server";

		public const string net_auth_context_expectation = "net_auth_context_expectation";

		public const string net_auth_context_expectation_remote = "net_auth_context_expectation_remote";

		public const string net_auth_eof = "net_auth_eof";

		public const string net_auth_ignored_reauth = "net_auth_ignored_reauth";

		public const string net_config_proxy_module_not_public = "net_config_proxy_module_not_public";

		public const string net_ftp_unsupported_method = "net_ftp_unsupported_method";

		public const string net_headerrestrict = "net_headerrestrict";

		public const string net_headers_req = "net_headers_req";

		public const string net_headers_rsp = "net_headers_rsp";

		public const string net_headers_toolong = "net_headers_toolong";

		public const string net_inasync = "net_inasync";

		public const string net_ftp_server_failed_passive = "net_ftp_server_failed_passive";

		public const string net_ftp_invalid_uri = "net_ftp_invalid_uri";

		public const string net_ftp_no_defaultcreds = "net_ftp_no_defaultcreds";

		public const string net_ftp_no_http_cmd = "net_ftp_no_http_cmd";

		public const string net_ftp_no_offsetforhttp = "net_ftp_no_offsetforhttp";

		public const string net_ftp_proxy_does_not_support_ssl = "net_ftp_proxy_does_not_support_ssl";

		public const string net_ftp_response_invalid_format = "net_ftp_response_invalid_format";

		public const string net_invalidAddressList = "net_invalidAddressList";

		public const string net_invasync = "net_invasync";

		public const string net_io_async_result = "net_io_async_result";

		public const string net_io_completionportwasbound = "net_io_completionportwasbound";

		public const string net_io_connectionclosed = "net_io_connectionclosed";

		public const string net_io_decrypt = "net_io_decrypt";

		public const string net_io_encrypt = "net_io_encrypt";

		public const string net_invalidversion = "net_invalidversion";

		public const string net_invalidPingBufferSize = "net_invalidPingBufferSize";

		public const string net_invalid_cast = "net_invalid_cast";

		public const string net_invalid_enum = "net_invalid_enum";

		public const string net_invalid_host = "net_invalid_host";

		public const string net_invalid_ip_addr = "net_invalid_ip_addr";

		public const string net_invalidstatus = "net_invalidstatus";

		public const string net_ftp_invalid_status_response = "net_ftp_invalid_status_response";

		public const string net_cookie_capacity_range = "net_cookie_capacity_range";

		public const string net_cookie_exists = "net_cookie_exists";

		public const string net_cookie_format = "Cookie format error.";

		public const string net_cookie_parse_header = "An error occurred when parsing the Cookie header for Uri '{0}'.";

		public const string net_cookie_size = "net_cookie_size";

		public const string net_empty_osinstalltype = "net_empty_osinstalltype";

		public const string net_cookie_attribute = "The '{0}'='{1}' part of the cookie is invalid.";

		public const string net_config_requestcaching = "net_config_requestcaching";

		public const string net_config_section_permission = "net_config_section_permission";

		public const string net_config_webrequestmodules = "net_config_webrequestmodules";

		public const string net_connarg = "net_connarg";

		public const string net_container_add_cookie = "net_container_add_cookie";

		public const string net_contentlengthmissing = "net_contentlengthmissing";

		public const string net_emptystringcall = "net_emptystringcall";

		public const string net_frame_size = "net_frame_size";

		public const string net_fromto = "net_fromto";

		public const string net_ftp_active_address_different = "net_ftp_active_address_different";

		public const string net_ftp_invalid_method_name = "net_ftp_invalid_method_name";

		public const string net_ftp_invalid_renameto = "net_ftp_invalid_renameto";

		public const string net_ftp_invalid_response_filename = "net_ftp_invalid_response_filename";

		public const string net_frame_read_size = "net_frame_read_size";

		public const string net_emptystringset = "net_emptystringset";

		public const string net_entire_body_not_written = "net_entire_body_not_written";

		public const string net_entitytoobig = "net_entitytoobig";

		public const string net_format_shexp = "net_format_shexp";

		public const string net_frame_max_size = "net_frame_max_size";

		public const string net_frame_read_io = "net_frame_read_io";

		public const string net_WebSockets_NotAWebSocket_Generic = "net_WebSockets_NotAWebSocket_Generic";

		public const string SmtpExceededStorageAllocation = "SmtpExceededStorageAllocation";

		public const string SmtpFromRequired = "SmtpFromRequired";

		public const string SmtpGetIisPickupDirectoryFailed = "SmtpGetIisPickupDirectoryFailed";

		public const string SmtpHelpMessage = "SmtpHelpMessage";

		public const string SmtpInsufficientStorage = "SmtpInsufficientStorage";

		public const string SmtpInvalidHostName = "SmtpInvalidHostName";

		public const string SmtpEhloResponseInvalid = "SmtpEhloResponseInvalid";

		public const string SmtpBadCommandSequence = "SmtpBadCommandSequence";

		public const string SmtpClientNotPermitted = "SmtpClientNotPermitted";

		public const string SmtpCommandNotImplemented = "SmtpCommandNotImplemented";

		public const string SmtpCommandParameterNotImplemented = "SmtpCommandParameterNotImplemented";

		public const string SmtpCommandUnrecognized = "SmtpCommandUnrecognized";

		public const string SmtpDataStreamOpen = "SmtpDataStreamOpen";

		public const string SmtpInvalidOperationDuringSend = "SmtpInvalidOperationDuringSend";

		public const string SmtpNonAsciiUserNotSupported = "SmtpNonAsciiUserNotSupported";

		public const string SmtpOK = "SmtpOK";

		public const string SmtpPickupDirectoryDoesnotSupportSsl = "SmtpPickupDirectoryDoesnotSupportSsl";

		public const string SmtpRecipientFailed = "SmtpRecipientFailed";

		public const string SmtpRecipientRequired = "SmtpRecipientRequired";

		public const string SmtpSendMailFailure = "SmtpSendMailFailure";

		public const string SmtpNeedAbsolutePickupDirectory = "SmtpNeedAbsolutePickupDirectory";

		public const string SmtpInvalidResponse = "SmtpInvalidResponse";

		public const string SmtpLocalErrorInProcessing = "SmtpLocalErrorInProcessing";

		public const string SmtpMailboxBusy = "SmtpMailboxBusy";

		public const string SmtpMailboxNameNotAllowed = "SmtpMailboxNameNotAllowed";

		public const string SmtpMailboxUnavailable = "SmtpMailboxUnavailable";

		public const string SmtpMustIssueStartTlsFirst = "SmtpMustIssueStartTlsFirst";

		public const string SmtpAuthenticationFailed = "SmtpAuthenticationFailed";

		public const string MailDateInvalidFormat = "MailDateInvalidFormat";

		public const string MailHeaderFieldInvalidCharacter = "MailHeaderFieldInvalidCharacter";

		public const string MailHeaderFieldMalformedHeader = "MailHeaderFieldMalformedHeader";

		public const string MailHeaderInvalidCID = "MailHeaderInvalidCID";

		public const string MailHostNotFound = "MailHostNotFound";

		public const string MailServerDoesNotSupportStartTls = "MailServerDoesNotSupportStartTls";

		public const string MailCollectionIsReadOnly = "MailCollectionIsReadOnly";

		public const string InvalidAsyncResult = "InvalidAsyncResult";

		public const string InvalidHeaderName = "InvalidHeaderName";

		public const string InvalidHexDigit = "InvalidHexDigit";

		public const string InvalidPort = "InvalidPort";

		public const string MailAddressInvalidFormat = "MailAddressInvalidFormat";

		public const string MailBase64InvalidCharacter = "MailBase64InvalidCharacter";

		public const string MailServerResponse = "MailServerResponse";

		public const string NotWriteableStream = "NotWriteableStream";

		public const string ReadNotSupported = "ReadNotSupported";

		public const string SSPIInvalidHandleType = "SSPIInvalidHandleType";

		public const string SeekNotSupported = "SeekNotSupported";

		public const string SmtpAlreadyConnected = "SmtpAlreadyConnected";

		public const string SmtpAuthResponseInvalid = "SmtpAuthResponseInvalid";

		public const string NotSupported = "NotSupported";

		public const string MailSubjectInvalidFormat = "MailSubjectInvalidFormat";

		public const string MailWriterIsInContent = "MailWriterIsInContent";

		public const string MediaTypeInvalid = "MediaTypeInvalid";

		public const string MimePartCantResetStream = "MimePartCantResetStream";

		public const string MimeTransferEncodingNotSupported = "MimeTransferEncodingNotSupported";

		public const string NotReadableStream = "NotReadableStream";

		public const string SmtpServiceClosingTransmissionChannel = "SmtpServiceClosingTransmissionChannel";

		public const string net_WebSockets_Argument_InvalidMessageType = "net_WebSockets_Argument_InvalidMessageType";

		public const string net_WebSockets_ClientAcceptingNoProtocols = "net_WebSockets_ClientAcceptingNoProtocols";

		public const string net_WebSockets_Connect101Expected = "net_WebSockets_Connect101Expected";

		public const string net_WebSockets_ConnectionClosedPrematurely_Generic = "net_WebSockets_ConnectionClosedPrematurely_Generic";

		public const string net_WebSockets_Generic = "net_WebSockets_Generic";

		public const string net_WebSockets_HeaderError_Generic = "net_WebSockets_HeaderError_Generic";

		public const string net_WebSockets_ArgumentOutOfRange_TooSmall = "net_WebSockets_ArgumentOutOfRange_TooSmall";

		public const string net_WebSockets_AcceptNotAWebSocket = "net_WebSockets_AcceptNotAWebSocket";

		public const string net_WebSockets_AcceptUnsupportedProtocol = "net_WebSockets_AcceptUnsupportedProtocol";

		public const string net_WebSockets_AcceptUnsupportedWebSocketVersion = "net_WebSockets_AcceptUnsupportedWebSocketVersion";

		public const string net_WebSockets_AlreadyStarted = "net_WebSockets_AlreadyStarted";

		public const string net_WebSockets_ArgumentOutOfRange_InternalBuffer = "net_WebSockets_ArgumentOutOfRange_InternalBuffer";

		public const string net_WebSockets_ArgumentOutOfRange_TooBig = "net_WebSockets_ArgumentOutOfRange_TooBig";

		public const string net_WebSockets_InvalidBufferType = "net_WebSockets_InvalidBufferType";

		public const string net_WebSockets_InvalidResponseHeader = "net_WebSockets_InvalidResponseHeader";

		public const string net_WebSockets_InvalidState = "net_WebSockets_InvalidState";

		public const string net_WebSockets_InvalidState_ClosedOrAborted = "net_WebSockets_InvalidState_ClosedOrAborted";

		public const string net_WebSockets_InvalidState_Generic = "net_WebSockets_InvalidState_Generic";

		public const string net_WebSockets_NativeSendResponseHeaders = "net_WebSockets_NativeSendResponseHeaders";

		public const string net_WebSockets_NoDuplicateProtocol = "net_WebSockets_NoDuplicateProtocol";

		public const string net_WebSockets_InvalidRegistration = "net_WebSockets_InvalidRegistration";

		public const string net_WebSockets_InvalidCharInProtocolString = "net_WebSockets_InvalidCharInProtocolString";

		public const string net_WebSockets_InvalidCloseStatusCode = "net_WebSockets_InvalidCloseStatusCode";

		public const string net_WebSockets_InvalidCloseStatusDescription = "net_WebSockets_InvalidCloseStatusDescription";

		public const string net_WebSockets_InvalidEmptySubProtocol = "net_WebSockets_InvalidEmptySubProtocol";

		public const string net_WebSockets_InvalidMessageType = "net_WebSockets_InvalidMessageType";

		public const string net_WebSockets_InvalidMessageType_Generic = "net_WebSockets_InvalidMessageType_Generic";

		public const string net_WebSockets_AcceptHeaderNotFound = "net_WebSockets_AcceptHeaderNotFound";

		public const string SmtpUserNotLocalWillForward = "SmtpUserNotLocalWillForward";

		public const string UnspecifiedHost = "UnspecifiedHost";

		public const string WinNTRequired = "WinNTRequired";

		public const string WinXPRequired = "WinXPRequired";

		public const string WriteNotSupported = "WriteNotSupported";

		public const string dns_bad_ip_address = "dns_bad_ip_address";

		public const string SmtpUserNotLocalTryAlternatePath = "SmtpUserNotLocalTryAlternatePath";

		public const string SmtpServiceNotAvailable = "SmtpServiceNotAvailable";

		public const string SmtpServiceReady = "SmtpServiceReady";

		public const string SmtpStartMailInput = "SmtpStartMailInput";

		public const string SmtpSyntaxError = "SmtpSyntaxError";

		public const string SmtpSystemStatus = "SmtpSystemStatus";

		public const string SmtpTransactionFailed = "SmtpTransactionFailed";

		public const string net_InvalidAddressFamily = "net_InvalidAddressFamily";

		public const string net_PropertyNotSupportedException = "net_PropertyNotSupportedException";

		public const string net_WebHeaderInvalidCRLFChars = "net_WebHeaderInvalidCRLFChars";

		public const string net_WebHeaderInvalidControlChars = "net_WebHeaderInvalidControlChars";

		public const string net_WebHeaderInvalidHeaderChars = "net_WebHeaderInvalidHeaderChars";

		public const string net_WebHeaderInvalidNonAsciiChars = "net_WebHeaderInvalidNonAsciiChars";

		public const string net_WebHeaderMissingColon = "net_WebHeaderMissingColon";

		public const string net_PropertyNotImplementedException = "net_PropertyNotImplementedException";

		public const string net_InvalidEndPointAddressFamily = "net_InvalidEndPointAddressFamily";

		public const string net_InvalidSocketAddressSize = "net_InvalidSocketAddressSize";

		public const string net_InvalidSocketHandle = "net_InvalidSocketHandle";

		public const string net_InvalidStatusCode = "net_InvalidStatusCode";

		public const string net_MethodNotImplementedException = "net_MethodNotImplementedException";

		public const string net_MethodNotSupportedException = "net_MethodNotSupportedException";

		//
		// Static Methods
		//
		public static object GetObject (string name)
		{
			return name;
		}

		internal static string GetString (CultureInfo culture, string name, params object[] args)
		{
			return string.Format (culture, name, args);
		}

		internal static string GetString (string name)
		{
			return name;
		}

		internal static string GetString (CultureInfo culture, string name)
		{
			return name;
		}

		internal static string GetString (string name, params object[] args)
		{
			return SR.GetString (CultureInfo.InvariantCulture, name, args);
		}
	}
}

